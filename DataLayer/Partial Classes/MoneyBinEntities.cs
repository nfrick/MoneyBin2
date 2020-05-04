using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;

namespace DataLayer {
    public partial class MoneyBinEntities {
        public int ChangesCount => ChangeTracker.Entries()
            .Count(entry => entry.State == EntityState.Added ||
                            entry.State == EntityState.Deleted ||
                            entry.State == EntityState.Modified);

        public bool AddedAny => ChangeTracker.Entries()
            .Any(entry => entry.State == EntityState.Added);

        public int AddedCount => ChangeTracker.Entries()
            .Count(entry => entry.State == EntityState.Added);

        public bool ModifiedAny => ChangeTracker.Entries()
            .Any(entry => entry.State == EntityState.Modified);

        public int ModifiedCount => ChangeTracker.Entries()
            .Count(entry => entry.State == EntityState.Modified);

        public bool DeletedAny => ChangeTracker.Entries()
            .Any(entry => entry.State == EntityState.Deleted);

        public int DeletedCount => ChangeTracker.Entries()
            .Count(entry => entry.State == EntityState.Deleted);

        public string TextoSalvar() {
            var alteracoes = ChangesCount;
            return $" Salvar {alteracoes} alteraç" + (alteracoes == 1 ? "ão" : "ões");
        }

        public bool SaveChanges(out string message) {
            var resultado = true;
            try {
                SaveChanges();
                message = null;
            }
            catch (DbEntityValidationException exception) {
                var entidades = exception.EntityValidationErrors;
                var sb = new StringBuilder();
                foreach (var entidade in entidades) {
                    var entry = entidade.Entry;
                    sb.Append($"\"{entry.Entity.GetType().Name} {entry.Entity}\", ação \"{entry.State}\":\n");
                    foreach (var erro in entidade.ValidationErrors) {
                        sb.Append($"\t{erro.ErrorMessage}\n");
                    }
                    sb.Append("\n\n");
                }
                message = sb.ToString();
                resultado = false;
            }
            return resultado;
        }

        public void RevertChanges() {
            RevertChanges(ChangeTracker.Entries());
        }

        public void RevertChanges(EntityState state) {
            RevertChanges(ChangeTracker.Entries().Where(e => e.State == state));
        }

        private void RevertChanges(IEnumerable<DbEntityEntry> entries) {
            foreach (var entry in entries) {
                switch (entry.State) {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}