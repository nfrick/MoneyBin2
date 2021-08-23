using DataLayer;
using MoneyBin2.Properties;
using NFExtensions;
using Syncfusion.Data;
using Syncfusion.Data.Extensions;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NF_sfDataGridExtensions;

namespace MoneyBin2 {
    public partial class frmBalanceSF : DataFormSf {
        private Conta ContaAtual => (Conta)_toolStripComboBoxConta.SelectedItem;

        private readonly ToolStripComboBox _toolStripComboBoxConta = new ToolStripComboBox
        {
            Name = "toolStripComboBoxConta",
            Size = new Size(100, 33),
        };

        private readonly ToolStripDateTimePicker _dtpInicio =
            new ToolStripDateTimePicker("dtpInicio", DateTime.Today.AddDays(-60), DateTimePickerFormat.Short)
            {
                Width = 100
            };

        private readonly ToolStripDateTimePicker _dtpTermino =
            new ToolStripDateTimePicker("dtpTermino", DateTime.Today, DateTimePickerFormat.Short) { Width = 100 };

        public frmBalanceSF() {
            InitializeComponent();

            MainDGV = dgvBalance;

            #region DATAGRID
            sfDataGridExtensions.FormatGrid(dgvBalance);

            dgvBalance.AllowDraggingColumns = true;
            dgvBalance.FrozenColumnCount = 2;
            dgvBalance.AddNewRowPosition = RowPosition.None;
            dgvBalance.ShowRowHeader = false;
            dgvBalance.SearchController.AllowFiltering = true;

            sfDataGridExtensions.SelectionColumn(dgvBalance);
            dgvBalance.Columns.Add(new GridTextColumn { MappingName = "Conta.Apelido", HeaderText = "Conta", Width = 90, AllowGrouping = true, Visible = true });
            dgvBalance.Columns.Add(new GridDateTimeColumn
            {
                MappingName = "Data",
                Format = "dd/MM/yy",
                AllowGrouping = true,
                Width = 80
            });
            dgvBalance.Columns.Add(new GridNumericColumn() { MappingName = "Dia", Width = 60, Format = "N0" });
            dgvBalance.Columns.Add(new GridTextColumn
            {
                MappingName = "Historico",
                AllowEditing = false,
                HeaderText = "Histórico",
                AutoSizeColumnsMode = AutoSizeColumnsMode.Fill
            });
            dgvBalance.Columns.Add(new GridNumericColumn
            {
                MappingName = "Valor",
                NumberFormatInfo = Application.CurrentCulture.NumberFormat,
                AllowEditing = false,
                Width = 90
            });
            dgvBalance.Columns.Add(new GridCheckBoxColumn
            {
                MappingName = "AfetaSaldo",
                HeaderText = "Afeta Saldo",
                AllowHeaderTextWrapping = true,
                Width = 70
            });
            dgvBalance.Columns.Add(new GridNumericColumn
            {
                MappingName = "Saldo",
                NumberFormatInfo = Application.CurrentCulture.NumberFormat,
                AllowEditing = false,
                AllowSorting = false,
                Width = 90
            });
            dgvBalance.Columns.Add(new GridTextColumn { MappingName = "Grupo", AllowGrouping = true, Width = 120 });
            dgvBalance.Columns.Add(new GridTextColumn { MappingName = "Categoria", AllowGrouping = true, Width = 120 });
            dgvBalance.Columns.Add(new GridTextColumn
            {
                MappingName = "SubCategoria",
                AllowGrouping = true,
                Width = 120
            });
            dgvBalance.Columns.Add(new GridTextColumn
            {
                MappingName = "Descricao",
                AllowSorting = false,
                AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill,
                HeaderText = "Descrição"
            });

            dgvBalance.Columns["Valor"].HeaderStyle.BackColor = Color.RoyalBlue;
            dgvBalance.Columns["AfetaSaldo"].HeaderStyle.BackColor = Color.RoyalBlue;
            dgvBalance.Columns["Saldo"].HeaderStyle.BackColor = Color.RoyalBlue;

            dgvBalance.DrawCell += SfDataGrid_DrawCell;
            dgvBalance.QueryRowStyle += SfDataGrid_QueryRowStyle;
            dgvBalance.QueryCheckBoxCellStyle += SfDataGrid_QueryCheckBoxCellStyle;

            dgvBalance.ColumnHeaderContextMenu = new ContextMenuStrip();
            dgvBalance.ColumnHeaderContextMenu.Items.Add("Colunas", null, ColumnPicker_Click);
            #endregion DATAGRID

            #region TOOLSTRIP
            toolStripMenu.Items.Add(new ToolStripLabel("Conta:"));
            toolStripMenu.Items.Add(_toolStripComboBoxConta);
            _toolStripComboBoxConta.ComboBox.Items.Add(new Conta { Apelido = "Todas" });
            _toolStripComboBoxConta.ComboBox.Items.AddRange(_ctx.Contas.OrderBy(c => c.Apelido).ToArray());
            _toolStripComboBoxConta.ComboBox.DisplayMember = "Apelido";
            _toolStripComboBoxConta.SelectedIndexChanged += FilterItemChanged;
            _toolStripComboBoxConta.ComboBox.SelectedItem =
                Settings.Default.BalanceUsarContaPadrao
                    ? _ctx.Contas.Find(Settings.Default.BalanceContaPadrao)
                    : _ctx.Contas.Find(Settings.Default.BalanceUltimaConta);

            #region DATAS

            toolStripMenu.Items.Add(new ToolStripSeparator());
            var lblInicio = new ToolStripLabel("Início:") { DoubleClickEnabled = true };
            lblInicio.DoubleClick += (sender, args) =>
                        {
                            _dtpInicio.Value = ContaAtual.DataMin;
                            if (_dtpInicio.Value > _dtpTermino.Value) {
                                _dtpTermino.Value = _dtpInicio.Value.AddMonths(3);
                            }
                        };
            toolStripMenu.Items.Add(lblInicio);
            toolStripMenu.Items.Add(_dtpInicio);
            _dtpInicio.ValueChanged += FilterItemChanged;

            var lblTermino = new ToolStripLabel("Término:") { DoubleClickEnabled = true };
            lblTermino.DoubleClick += (sender, args) =>
                        {
                            _dtpTermino.Value = ContaAtual.DataMax;
                            if (_dtpInicio.Value > _dtpTermino.Value) {
                                _dtpInicio.Value = _dtpTermino.Value.AddMonths(-3);
                            }
                        };
            toolStripMenu.Items.Add(lblTermino);
            toolStripMenu.Items.Add(_dtpTermino);
            _dtpTermino.ValueChanged += FilterItemChanged;

            #endregion DATAS

            #region PROCURAR

            toolStripMenu.Items.Add(new ToolStripSeparator());
            toolStripMenu.Items.Add(new ToolStripLabel("Procurar:"));
            var toolStripTextBoxProcurar = new ToolStripTextBox
            {
                Name = "toolStripTextBoxProcurar",
                Size = new Size(150, 33)
            };
            toolStripMenu.Items.Add(toolStripTextBoxProcurar);
            toolStripTextBoxProcurar.TextChanged += toolStripTextBoxProcurar_TextChanged;

            #endregion PROCURAR

            #region WORDWRAP

            var chkboxWordWrap = new ToolStripCheckbox("chkboxWordWrap", "Word Wrap", true)
            {
                ForeColor = SystemColors.ControlText,
                BackColor = Color.Silver,
                Checked = false,
                ToolTipText = "Word wrap no Histórico"
            };
            toolStripMenu.Items.Add(new ToolStripSeparator());
            toolStripMenu.Items.Add(chkboxWordWrap);
            chkboxWordWrap.CheckedChanged += (sender, args) =>
            {
                var chk = (ToolStripCheckbox)sender;
                if (chk.Checked) {
                    dgvBalance.Columns["Historico"].AllowTextWrapping = true;
                    dgvBalance.QueryRowHeight += dgvBalance_QueryRowHeight;
                }
                else {
                    dgvBalance.Columns["Historico"].AllowTextWrapping = false;
                    dgvBalance.QueryRowHeight -= dgvBalance_QueryRowHeight;
                }
                dgvBalance.Refresh();
            };

            #endregion WORDWRAP


            var font = new Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foreach (var item in toolStripMenu.Items.Cast<ToolStripItem>()) {
                item.Font = font;
            }

            EnableSaveButtons();
            #endregion TOOLSTRIP

            #region SORTING AND GROUPING
            dgvBalance.SortColumnDescriptions.Add(new SortColumnDescription()
            {
                ColumnName = "Data",
                SortDirection = ListSortDirection.Descending
            });
            dgvBalance.SortColumnDescriptions.Add(new SortColumnDescription()
            {
                ColumnName = "Dia",
                SortDirection = ListSortDirection.Descending
            });
            dgvBalance.SortColumnDescriptions.Add(new SortColumnDescription()
            {
                ColumnName = "Valor",
                SortDirection = ListSortDirection.Ascending
            });


            dgvBalance.GroupColumnDescriptions.CollectionChanged += GroupColumnDescriptions_CollectionChanged;
            dgvBalance.GroupCaptionTextFormat = "{Key}";
            dgvBalance.GroupColumnDescriptions.Add(new GroupColumnDescription
            {
                ColumnName = "Data",
                KeySelector = (string columnName, object o) => (o as BalanceItem)?.Data.ToString("yyyy-MM")
            });
            #endregion

            Width = (int)sfDataGridExtensions.GetWidth(dgvBalance);
            Width -= 70;
        }

        #region FORM
        private void SfDataGrid_DrawCell(object sender, DrawCellEventArgs e) {
            sfDataGridExtensions.DrawCell(sender, e);
            Console.WriteLine((e.DataRow as DataRowBase).RowType);
            if ((e.DataRow as DataRowBase).RowType != RowType.HeaderRow) {
                return;
            }

            switch (e.CellValue) {
                case "Info":
                    e.Style.BackColor = Color.DarkSlateGray;
                    break;
                case "Valores":
                    e.Style.BackColor = Color.SlateGray;
                    break;
                case "Classificação":
                    e.Style.BackColor = Color.DarkSlateGray;
                    break;
            }
        }

        private void SfDataGrid_QueryRowStyle(object sender, QueryRowStyleEventArgs e) {
            sfDataGridExtensions.QueryRowStyle(sender, e);
        }

        void SfDataGrid_QueryCheckBoxCellStyle(object sender, QueryCheckBoxCellStyleEventArgs e) {
            sfDataGridExtensions.QueryCheckBoxCellStyle(sender, e);
        }

        #endregion FORM

        #region DATAGRID
        private void dgvBalance_QueryRowHeight(object sender, QueryRowHeightEventArgs e) {
            sfDataGridExtensions.QueryRowHeight(sender, e);
        }

        private void dgvBalance_CellClick(object sender, CellClickEventArgs e) {
            if (e.MouseEventArgs.Button != MouseButtons.Right ||
                e.DataRow.RowType != RowType.DefaultRow ||
                !"Grupo,Categoria,SubCategoria".Contains(e.DataColumn.GridColumn.HeaderText)) {
                return;
            }

            ClassifTools.PopupOptions(sender, e, cmsPopMenu);
        }

        private void cmsPopMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            ClassifTools.PopupItemClicked(sender, e, dgvBalance);
            EnableSaveButtons();
        }

        private void dgvBalance_QueryCellStyle(object sender, QueryCellStyleEventArgs e) {
            var x = e.Column.HeaderText;
            if (e.DataRow.RowType != RowType.DefaultRow || (x != "Valor" && x != "Saldo")) {
                return;
            }
            var item = (BalanceItem)e.DataRow.RowData;
            var valor = x == "Valor" ? item.Valor : item.Saldo;
            if (valor >= 0) {
                return;
            }
            e.Style.TextColor = Color.Orange;
        }

        private void dgvBalance_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e) {
            EnableSaveButtons();
        }

        private void ColumnPicker_Click(object sender, EventArgs e) {
            sfDataGridExtensions.ColumnPicker(dgvBalance);
        }

        private void GroupColumnDescriptions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            if (e.Action == NotifyCollectionChangedAction.Add) {
                var group = (GroupColumnDescription)e.NewItems[0];
                if (group.ColumnName == "Data") {
                    group.KeySelector = (string columnName, object o) => (o as BalanceItem)?.Data.ToString("yyyy-MM");
                    dgvBalance.Columns["Dia"].Visible = true;
                    dgvBalance.Columns["Data"].Visible = false;
                }
                else if (group.ColumnName == "Conta.Apelido") {
                    dgvBalance.Columns["Conta.Apelido"].Visible = false;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove) {
                var group = (GroupColumnDescription)e.OldItems[0];
                if (group.ColumnName == "Data") {
                    dgvBalance.Columns["Dia"].Visible = false;
                    dgvBalance.Columns["Data"].Visible = true;
                }
                else if (group.ColumnName == "Conta.Apelido") {
                    dgvBalance.Columns["Conta.Apelido"].Visible = true;
                }
            }
        }

        private void FilterItemChanged(object sender, EventArgs e) {
            dgvBalance.ShowBusyIndicator = true;
            if (ContaAtual.ID == 0) {
                dgvBalance.DataSource = _ctx.Balance
                    .Where(b => b.Data >= _dtpInicio.Value && b.Data <= _dtpTermino.Value)
                    .ToObservableCollection();
                dgvBalance.Columns["Conta.Apelido"].Visible = true;
            }
            else {
                dgvBalance.DataSource = ContaAtual.Balance
                    .Where(b => b.Data >= _dtpInicio.Value && b.Data <= _dtpTermino.Value)
                    .ToObservableCollection();
                dgvBalance.Columns["Conta.Apelido"].Visible = false;
            }

            dgvBalance.ShowBusyIndicator = false;
        }
        #endregion DATAGRID

        private void toolStripTextBoxProcurar_TextChanged(object sender, EventArgs e) {
            var txt = ((ToolStripTextBox)sender).Text;
            if (string.IsNullOrEmpty(txt)) {
                dgvBalance.SearchController.ClearSearch();
            }
            else {
                dgvBalance.SearchController.Search(txt);
            }
        }
    }
}