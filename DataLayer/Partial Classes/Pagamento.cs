using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    [Flags]
    public enum MesesDoAno {
        //None = 0,
        Jan = 1, Fev = 2, Mar = 4, Abr = 8, Mai = 16, Jun = 32,
        Jul = 64, Ago = 128, Set = 256, Out = 512, Nov = 1024, Dez = 2048
    }
    public partial class Pagamento {
        public override string ToString() => $@"{Grupo}\{Categoria}\{SubCategoria}" +
                                             (Descricao == null
            ? ""
            : $"\\{Descricao}");

        private static Array TodosOsMeses => Enum.GetValues(typeof(MesesDoAno));
        private static IEnumerable<MesesDoAno> TodosOsMesesCast => TodosOsMeses.Cast<MesesDoAno>();

        public bool Inativo {
            get => !TodosOsMesesCast.Any(IsMonth);
            set {
                if (!value) {
                    return;
                }

                foreach (MesesDoAno m in TodosOsMeses) {
                    SetMonth(m, false);
                }
            }
        }

        public bool AnoInteiro {
            get => TodosOsMesesCast.All(IsMonth);
            set {
                if (!value) {
                    return;
                }

                foreach (MesesDoAno m in TodosOsMeses) {
                    SetMonth(m, value);
                }
            }
        }

        public bool AlgunsMeses => !Inativo && !AnoInteiro;

        public bool Jan {
            get => IsMonth(MesesDoAno.Jan);
            set => SetMonth(MesesDoAno.Jan, value);
        }
        public bool Fev {
            get => IsMonth(MesesDoAno.Fev);
            set => SetMonth(MesesDoAno.Fev, value);
        }
        public bool Mar {
            get => IsMonth(MesesDoAno.Mar);
            set => SetMonth(MesesDoAno.Mar, value);
        }
        public bool Abr {
            get => IsMonth(MesesDoAno.Abr);
            set => SetMonth(MesesDoAno.Abr, value);
        }
        public bool Mai {
            get => IsMonth(MesesDoAno.Mai);
            set => SetMonth(MesesDoAno.Mai, value);
        }
        public bool Jun {
            get => IsMonth(MesesDoAno.Jun);
            set => SetMonth(MesesDoAno.Jun, value);
        }
        public bool Jul {
            get => IsMonth(MesesDoAno.Jul);
            set => SetMonth(MesesDoAno.Jul, value);
        }
        public bool Ago {
            get => IsMonth(MesesDoAno.Ago);
            set => SetMonth(MesesDoAno.Ago, value);
        }
        public bool Set {
            get => IsMonth(MesesDoAno.Set);
            set => SetMonth(MesesDoAno.Set, value);
        }
        public bool Out {
            get => IsMonth(MesesDoAno.Out);
            set => SetMonth(MesesDoAno.Out, value);
        }
        public bool Nov {
            get => IsMonth(MesesDoAno.Nov);
            set => SetMonth(MesesDoAno.Nov, value);
        }
        public bool Dez {
            get => IsMonth(MesesDoAno.Dez);
            set => SetMonth(MesesDoAno.Dez, value);
        }

        private bool IsMonth(MesesDoAno m) {
            return (Meses & (int)m) == (int)m;
        }

        private void SetMonth(MesesDoAno m, bool b) {
            if (b) {
                Meses |= (int)m;
            }
            else {
                Meses &= ~(int)m;
            }
        }
    }
}
