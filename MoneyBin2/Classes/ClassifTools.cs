using DataLayer;
using Syncfusion.Data.Extensions;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Interactivity;

namespace MoneyBin2 {
    public static class ClassifTools {
        private static readonly Classificacao[] Classificacao = new MoneyBinEntities().spClassificacao().ToArray();

        public static void EditingControlShowing(object sender,
            DataGridViewEditingControlShowingEventArgs e) {
            var dgv = (DataGridView)sender;
            var row = dgv.CurrentCell.RowIndex;
            var col = dgv.CurrentCell.ColumnIndex;
            var bi = (BalanceItem)dgv.Rows[row].DataBoundItem;
            var txt = e.Control as TextBox;
            txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            switch (dgv.Columns[col].HeaderText) {
                case "Grupo":
                    txt.AutoCompleteCustomSource =
                        CreateCollection(GetListOfGrupos(dgv));
                    break;
                case "Categoria":
                    txt.AutoCompleteCustomSource =
                        CreateCollection(GetListOfCategorias(dgv, bi));
                    break;
                case "SubCategoria":
                    txt.AutoCompleteCustomSource =
                        CreateCollection(GetListOfSubCategorias(dgv, bi));
                    break;
                default:
                    txt.AutoCompleteMode = AutoCompleteMode.None;
                    break;
            }
        }

        private static AutoCompleteStringCollection CreateCollection(IEnumerable<string> lista) {
            var source = new AutoCompleteStringCollection();
            source.AddRange(lista.Distinct().Where(a => !string.IsNullOrEmpty(a)).ToArray());
            return source;
        }

        public static IEnumerable<string> GetListOfGrupos(int sinal = 0) {
            return sinal == 0 ?
                Classificacao
                    .Where(c => !string.IsNullOrEmpty(c.Grupo))
                    .Select(c => c.Grupo)
                    .Distinct()
                    .OrderBy(g => g) :
                Classificacao
                    .Where(c => c.Sinal == sinal && !string.IsNullOrEmpty(c.Grupo))
                    .Select(c => c.Grupo)
                    .Distinct()
                    .OrderBy(g => g); ;
        }

        private static IEnumerable<BalanceItem> GetDGVData(DataGridView dgv) {
            var bs = (BindingSource)dgv.DataSource;
            try {
                return ((IOrderedEnumerable<BalanceItem>)bs.DataSource).ToList();
            }
            catch (Exception) {
                return ((IEnumerable<BalanceItem>)bs.DataSource).ToList();
            }
        }

        private static IEnumerable<BalanceItem> GetDGVData(SfDataGrid dgv) {
            var bs = dgv.DataSource;
            try {
                return ((IOrderedEnumerable<BalanceItem>)bs).ToList();
            }
            catch (Exception) {
                return ((IEnumerable<BalanceItem>)bs).ToList();
            }
        }

        public static IEnumerable<string> GetListOfGrupos(DataGridView dgv, int sinal = 0) {
            var source = GetDGVData(dgv);

            var items = sinal == 0
                ? source.Where(s => !string.IsNullOrEmpty(s.Grupo))
                    .Select(s => s.Grupo)
                : source.Where(c => c.Sinal == sinal && !string.IsNullOrEmpty(c.Grupo))
                    .Select(c => c.Grupo);

            return GetListOfGrupos(sinal)
                .Union(items)
                .OrderBy(g => g);
        }

        public static IEnumerable<string> GetListOfGrupos(SfDataGrid dgv, int sinal = 0) {
            var source = GetDGVData(dgv);

            var items = sinal == 0
                ? source.Where(s => !string.IsNullOrEmpty(s.Grupo))
                    .Select(s => s.Grupo)
                : source.Where(c => c.Sinal == sinal && !string.IsNullOrEmpty(c.Grupo))
                    .Select(c => c.Grupo);

            return GetListOfGrupos(sinal)
                .Union(items)
                .OrderBy(g => g);
        }


        public static IEnumerable<string> GetListOfCategorias(string grupo, int sinal = 0) {
            return sinal == 0 ?
                Classificacao
                    .Where(c => c.Grupo == grupo && !string.IsNullOrEmpty(c.Categoria))
                    .Select(c => c.Categoria)
                    .Distinct()
                    .OrderBy(c => c) :
                Classificacao
                    .Where(c => c.Sinal == sinal && c.Grupo == grupo && !string.IsNullOrEmpty(c.Categoria))
                    .Select(c => c.Categoria)
                    .Distinct()
                    .OrderBy(c => c);
        }

        public static IEnumerable<string> GetListOfCategorias(DataGridView dgv, BalanceItem item) {
            var source = GetDGVData(dgv);
            var items = source
                    .Where(c => c.Sinal == item.Sinal &&
                        c.Grupo == item.Grupo &&
                        !string.IsNullOrEmpty(c.Categoria))
                .Select(c => c.Categoria);

            return GetListOfCategorias(item.Grupo, item.Sinal)
                .Union(items)
                .OrderBy(c => c);
        }

        public static IEnumerable<string> GetListOfCategorias(SfDataGrid dgv, BalanceItem item) {
            var source = GetDGVData(dgv);
            var items = source
                .Where(c => c.Sinal == item.Sinal &&
                            c.Grupo == item.Grupo &&
                            !string.IsNullOrEmpty(c.Categoria))
                .Select(c => c.Categoria);

            return GetListOfCategorias(item.Grupo, item.Sinal)
                .Union(items)
                .OrderBy(c => c);
        }

        public static IEnumerable<string> GetListOfSubCategorias(string grupo, string categoria, int sinal = 0) {
            return sinal == 0 ?
                Classificacao
                    .Where(c => c.Grupo == grupo && c.Categoria == categoria && !string.IsNullOrEmpty(c.SubCategoria))
                    .Select(c => c.SubCategoria)
                    .Distinct()
                    .OrderBy(s => s) :
                Classificacao
                    .Where(c => c.Sinal == sinal &&
                                c.Grupo == grupo &&
                                c.Categoria == categoria &&
                                !string.IsNullOrEmpty(c.SubCategoria))
                    .Select(c => c.SubCategoria)
                    .Distinct()
                    .OrderBy(s => s)
                ;
        }

        public static IEnumerable<string> GetListOfSubCategorias(DataGridView dgv, BalanceItem item) {
            var source = GetDGVData(dgv);
            var items = source.Where(c => c.Sinal == item.Sinal &&
                                          c.Grupo == item.Grupo &&
                                          c.Categoria == item.Categoria &&
                                          !string.IsNullOrEmpty(c.SubCategoria))
                .Select(c => c.SubCategoria);

            return GetListOfSubCategorias(item.Grupo, item.Categoria, item.Sinal)
                    .Union(items)
                    .OrderBy(s => s); ;
        }

        public static IEnumerable<string> GetListOfSubCategorias(SfDataGrid dgv, BalanceItem item) {
            var source = GetDGVData(dgv);
            var items = source.Where(c => c.Sinal == item.Sinal &&
                                          c.Grupo == item.Grupo &&
                                          c.Categoria == item.Categoria &&
                                          !string.IsNullOrEmpty(c.SubCategoria))
                .Select(c => c.SubCategoria);

            return GetListOfSubCategorias(item.Grupo, item.Categoria, item.Sinal)
                .Union(items)
                .OrderBy(s => s); ;
        }

        public static void PopupOptions(object sender, MouseEventArgs e,
            ContextMenuStrip menu) {
            var dgv = (DataGridView)sender;

            var colGrupo = dgv.Columns["Grupo"].Index;
            var colCat = dgv.Columns["Categoria"].Index;
            var colSubCat = dgv.Columns["SubCategoria"].Index;

            var mouseOverRow = dgv.HitTest(e.X, e.Y).RowIndex;
            var mouseOverCol = dgv.HitTest(e.X, e.Y).ColumnIndex;
            if (e.Button != MouseButtons.Right || mouseOverRow == -1 ||
                mouseOverCol < colGrupo || mouseOverCol > colSubCat) {
                return;
            }

            dgv.CurrentCell = dgv.Rows[mouseOverRow].Cells[mouseOverCol];
            dgv.Rows[mouseOverRow].Selected = true;
            var item = (BalanceItem)dgv.CurrentRow.DataBoundItem;

            IEnumerable<string> opcoes;
            if (mouseOverCol == colGrupo) {
                opcoes = GetListOfGrupos(dgv);
            }
            else if (mouseOverCol == colCat) {
                opcoes = GetListOfCategorias(dgv, item);
            }
            else {
                opcoes = GetListOfSubCategorias(dgv, item);
            }
            menu.Items.Clear();
            foreach (var opcao in opcoes.OrderBy(c => c)) {
                menu.Items.Add(opcao);
            }
            menu.Tag = mouseOverCol;
            menu.Show(Cursor.Position);
        }

        public static void PopupOptions(object sender, CellClickEventArgs e,
            ContextMenuStrip menu) {
            var dgv = (SfDataGrid)sender;

            var item = (BalanceItem)e.DataRow.RowData;

            IEnumerable<string> opcoes;
            switch (e.DataColumn.GridColumn.HeaderText) {
                case "Grupo":
                    opcoes = GetListOfGrupos(dgv);
                    break;
                case "Categoria":
                    opcoes = GetListOfCategorias(dgv, item);
                    break;
                default:
                    opcoes = GetListOfSubCategorias(dgv, item);
                    break;
            }
            menu.Items.Clear();
            foreach (var opcao in opcoes.OrderBy(c => c)) {
                menu.Items.Add(opcao);
            }
            menu.Tag = e.DataColumn.ColumnIndex;
            menu.Show(Cursor.Position);
        }
        
        public static void PopupItemClicked(object sender, ToolStripItemClickedEventArgs e, DataGridView dgv) {
            var menu = (ContextMenuStrip)sender;
            var col = (int)menu.Tag;
            var atual = dgv.CurrentRow.Cells[col].Value;
            if (atual != null && atual.ToString() == e.ClickedItem.Text) {
                return;
            }

            dgv.CurrentRow.Cells[col].Value = e.ClickedItem.Text;
        }

        public static void PopupItemClicked(object sender, ToolStripItemClickedEventArgs e, SfDataGrid dgv) {
            var menu = (ContextMenuStrip)sender;
            var col = (int)menu.Tag;
            var atual = dgv.CurrentCell.CellRenderer.GetControlValue();
            if (atual != null && atual.ToString() == e.ClickedItem.Text) {
                return;
            }
            //dgv.CurrentCell.CellRenderer.SetControlValue(e.ClickedItem.Text);

            var row = dgv.CurrentCell.RowIndex;
            col = dgv.CurrentCell.ColumnIndex -1;

            dgv.View.GetPropertyAccessProvider()
                .SetValue(dgv.GetRecordAtRowIndex(row), dgv.Columns[col].MappingName, e.ClickedItem.Text);

            dgv.Refresh();
        }
    }
}