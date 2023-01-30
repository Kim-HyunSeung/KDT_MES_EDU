namespace KDT_Form
{
    partial class WM_TradingManager
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
			this.lblPlantCode = new DC00_Component.SLabel();
			this.cboPlantCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.grid1 = new DC00_Component.Grid(this.components);
			this.txtInvoiceNO = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.lblWorkerName_H = new DC00_Component.SLabel();
			this.dtpStartDate = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.sLabel6 = new DC00_Component.SLabel();
			this.dtpEndDate = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.sLabel4 = new DC00_Component.SLabel();
			this.txtCarNo = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.sLabel1 = new DC00_Component.SLabel();
			this.btnInvPrint = new Infragistics.Win.Misc.UltraButton();
			this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
			this.ultraSplitter1 = new Infragistics.Win.Misc.UltraSplitter();
			this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
			this.grid2 = new DC00_Component.Grid(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).BeginInit();
			this.gbxHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbxBody)).BeginInit();
			this.gbxBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpStartDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpEndDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCarNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
			this.ultraGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
			this.ultraGroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxHeader
			// 
			this.gbxHeader.ContentPadding.Bottom = 2;
			this.gbxHeader.ContentPadding.Left = 2;
			this.gbxHeader.ContentPadding.Right = 2;
			this.gbxHeader.ContentPadding.Top = 4;
			this.gbxHeader.Controls.Add(this.btnInvPrint);
			this.gbxHeader.Controls.Add(this.txtCarNo);
			this.gbxHeader.Controls.Add(this.sLabel1);
			this.gbxHeader.Controls.Add(this.dtpStartDate);
			this.gbxHeader.Controls.Add(this.sLabel6);
			this.gbxHeader.Controls.Add(this.dtpEndDate);
			this.gbxHeader.Controls.Add(this.sLabel4);
			this.gbxHeader.Controls.Add(this.txtInvoiceNO);
			this.gbxHeader.Controls.Add(this.lblWorkerName_H);
			this.gbxHeader.Controls.Add(this.cboPlantCode);
			this.gbxHeader.Controls.Add(this.lblPlantCode);
			this.gbxHeader.Location = new System.Drawing.Point(3, 3);
			this.gbxHeader.Size = new System.Drawing.Size(1289, 133);
			// 
			// gbxBody
			// 
			this.gbxBody.ContentPadding.Bottom = 4;
			this.gbxBody.ContentPadding.Left = 4;
			this.gbxBody.ContentPadding.Right = 4;
			this.gbxBody.ContentPadding.Top = 6;
			this.gbxBody.Controls.Add(this.ultraGroupBox2);
			this.gbxBody.Controls.Add(this.ultraSplitter1);
			this.gbxBody.Controls.Add(this.ultraGroupBox1);
			this.gbxBody.Location = new System.Drawing.Point(3, 136);
			this.gbxBody.Size = new System.Drawing.Size(1289, 611);
			// 
			// lblPlantCode
			// 
			appearance2.FontData.BoldAsString = "False";
			appearance2.FontData.UnderlineAsString = "False";
			appearance2.ForeColor = System.Drawing.Color.Black;
			appearance2.TextHAlignAsString = "Right";
			appearance2.TextVAlignAsString = "Middle";
			this.lblPlantCode.Appearance = appearance2;
			this.lblPlantCode.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
			this.lblPlantCode.DbField = null;
			this.lblPlantCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblPlantCode.Location = new System.Drawing.Point(45, 22);
			this.lblPlantCode.Name = "lblPlantCode";
			this.lblPlantCode.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.lblPlantCode.Size = new System.Drawing.Size(83, 23);
			this.lblPlantCode.TabIndex = 181;
			this.lblPlantCode.Text = "공장";
			// 
			// cboPlantCode
			// 
			this.cboPlantCode.Font = new System.Drawing.Font("맑은 고딕", 10F);
			this.cboPlantCode.Location = new System.Drawing.Point(134, 21);
			this.cboPlantCode.Name = "cboPlantCode";
			this.cboPlantCode.Size = new System.Drawing.Size(145, 27);
			this.cboPlantCode.TabIndex = 0;
			// 
			// grid1
			// 
			this.grid1.AutoResizeColumn = true;
			this.grid1.AutoUserColumn = true;
			this.grid1.ContextMenuCopyEnabled = true;
			this.grid1.ContextMenuDeleteEnabled = true;
			this.grid1.ContextMenuExcelEnabled = true;
			this.grid1.ContextMenuInsertEnabled = true;
			this.grid1.ContextMenuPasteEnabled = true;
			this.grid1.DeleteButtonEnable = true;
			appearance1.BackColor = System.Drawing.SystemColors.Window;
			appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
			this.grid1.DisplayLayout.Appearance = appearance1;
			this.grid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
			this.grid1.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty;
			appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder;
			appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
			appearance5.BorderColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.GroupByBox.Appearance = appearance5;
			appearance6.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance6;
			this.grid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid1.DisplayLayout.GroupByBox.Hidden = true;
			appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight;
			appearance8.BackColor2 = System.Drawing.SystemColors.Control;
			appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance8.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid1.DisplayLayout.GroupByBox.PromptAppearance = appearance8;
			this.grid1.DisplayLayout.MaxColScrollRegions = 1;
			this.grid1.DisplayLayout.MaxRowScrollRegions = 1;
			appearance9.BackColor = System.Drawing.SystemColors.Window;
			appearance9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.grid1.DisplayLayout.Override.ActiveCellAppearance = appearance9;
			appearance10.BackColor = System.Drawing.SystemColors.Highlight;
			appearance10.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.grid1.DisplayLayout.Override.ActiveRowAppearance = appearance10;
			this.grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
			this.grid1.DisplayLayout.Override.AllowMultiCellOperations = ((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)((((((((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.CopyWithHeaders) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Delete) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Undo) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Redo) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Reserved)));
			this.grid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
			this.grid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
			appearance11.BackColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.Override.CardAreaAppearance = appearance11;
			appearance12.BorderColor = System.Drawing.Color.Silver;
			appearance12.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
			this.grid1.DisplayLayout.Override.CellAppearance = appearance12;
			this.grid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
			this.grid1.DisplayLayout.Override.CellPadding = 0;
			appearance13.BackColor = System.Drawing.SystemColors.Control;
			appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance13.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
			appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance13.BorderColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.Override.GroupByRowAppearance = appearance13;
			this.grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
			this.grid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
			appearance14.BackColor = System.Drawing.SystemColors.Window;
			appearance14.BorderColor = System.Drawing.Color.Silver;
			this.grid1.DisplayLayout.Override.RowAppearance = appearance14;
			this.grid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
			appearance15.BackColor = System.Drawing.SystemColors.ControlLight;
			this.grid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance15;
			this.grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
			this.grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
			this.grid1.DisplayLayout.SelectionOverlayBorderThickness = 2;
			this.grid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
			this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid1.EnterNextRowEnable = true;
			this.grid1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.grid1.Location = new System.Drawing.Point(3, 24);
			this.grid1.Name = "grid1";
			this.grid1.Size = new System.Drawing.Size(1271, 255);
			this.grid1.TabIndex = 6;
			this.grid1.TabStop = false;
			this.grid1.Text = "grid1";
			this.grid1.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			this.grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
			this.grid1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
			this.grid1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
			this.grid1.AfterRowActivate += new System.EventHandler(this.grid1_AfterRowActivate);
			// 
			// txtInvoiceNO
			// 
			this.txtInvoiceNO.AutoSize = false;
			this.txtInvoiceNO.Font = new System.Drawing.Font("맑은 고딕", 10F);
			this.txtInvoiceNO.Location = new System.Drawing.Point(134, 63);
			this.txtInvoiceNO.Name = "txtInvoiceNO";
			this.txtInvoiceNO.Size = new System.Drawing.Size(145, 27);
			this.txtInvoiceNO.TabIndex = 185;
			// 
			// lblWorkerName_H
			// 
			appearance7.FontData.BoldAsString = "False";
			appearance7.FontData.UnderlineAsString = "False";
			appearance7.ForeColor = System.Drawing.Color.Black;
			appearance7.TextHAlignAsString = "Right";
			appearance7.TextVAlignAsString = "Middle";
			this.lblWorkerName_H.Appearance = appearance7;
			this.lblWorkerName_H.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
			this.lblWorkerName_H.DbField = "cboUseFlag";
			this.lblWorkerName_H.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblWorkerName_H.Location = new System.Drawing.Point(11, 66);
			this.lblWorkerName_H.Name = "lblWorkerName_H";
			this.lblWorkerName_H.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.lblWorkerName_H.Size = new System.Drawing.Size(117, 23);
			this.lblWorkerName_H.TabIndex = 186;
			this.lblWorkerName_H.Text = "거래 명세";
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.DateButtons.Add(dateButton1);
			this.dtpStartDate.Location = new System.Drawing.Point(409, 19);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.NonAutoSizeHeight = 26;
			this.dtpStartDate.Size = new System.Drawing.Size(142, 26);
			this.dtpStartDate.TabIndex = 188;
			// 
			// sLabel6
			// 
			appearance4.FontData.BoldAsString = "False";
			appearance4.FontData.UnderlineAsString = "False";
			appearance4.ForeColor = System.Drawing.Color.Black;
			appearance4.TextHAlignAsString = "Right";
			appearance4.TextVAlignAsString = "Middle";
			this.sLabel6.Appearance = appearance4;
			this.sLabel6.DbField = null;
			this.sLabel6.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.sLabel6.Location = new System.Drawing.Point(502, 19);
			this.sLabel6.Name = "sLabel6";
			this.sLabel6.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel6.Size = new System.Drawing.Size(81, 25);
			this.sLabel6.TabIndex = 190;
			this.sLabel6.Text = "~";
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.DateButtons.Add(dateButton2);
			this.dtpEndDate.Location = new System.Drawing.Point(589, 19);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.NonAutoSizeHeight = 26;
			this.dtpEndDate.Size = new System.Drawing.Size(147, 26);
			this.dtpEndDate.TabIndex = 189;
			// 
			// sLabel4
			// 
			appearance20.FontData.BoldAsString = "False";
			appearance20.FontData.UnderlineAsString = "False";
			appearance20.ForeColor = System.Drawing.Color.Black;
			appearance20.TextHAlignAsString = "Right";
			appearance20.TextVAlignAsString = "Middle";
			this.sLabel4.Appearance = appearance20;
			this.sLabel4.DbField = null;
			this.sLabel4.Font = new System.Drawing.Font("맑은 고딕", 12F);
			this.sLabel4.Location = new System.Drawing.Point(306, 17);
			this.sLabel4.Name = "sLabel4";
			this.sLabel4.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel4.Size = new System.Drawing.Size(97, 25);
			this.sLabel4.TabIndex = 187;
			this.sLabel4.Text = "출고 일자";
			// 
			// txtCarNo
			// 
			this.txtCarNo.AutoSize = false;
			this.txtCarNo.Font = new System.Drawing.Font("맑은 고딕", 10F);
			this.txtCarNo.Location = new System.Drawing.Point(406, 63);
			this.txtCarNo.Name = "txtCarNo";
			this.txtCarNo.Size = new System.Drawing.Size(145, 27);
			this.txtCarNo.TabIndex = 191;
			// 
			// sLabel1
			// 
			appearance3.FontData.BoldAsString = "False";
			appearance3.FontData.UnderlineAsString = "False";
			appearance3.ForeColor = System.Drawing.Color.Black;
			appearance3.TextHAlignAsString = "Right";
			appearance3.TextVAlignAsString = "Middle";
			this.sLabel1.Appearance = appearance3;
			this.sLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
			this.sLabel1.DbField = "cboUseFlag";
			this.sLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.sLabel1.Location = new System.Drawing.Point(283, 66);
			this.sLabel1.Name = "sLabel1";
			this.sLabel1.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel1.Size = new System.Drawing.Size(117, 23);
			this.sLabel1.TabIndex = 192;
			this.sLabel1.Text = "차량 번호";
			// 
			// btnInvPrint
			// 
			this.btnInvPrint.Location = new System.Drawing.Point(769, 22);
			this.btnInvPrint.Name = "btnInvPrint";
			this.btnInvPrint.Size = new System.Drawing.Size(155, 72);
			this.btnInvPrint.TabIndex = 193;
			this.btnInvPrint.Text = "명세서 발행";
			this.btnInvPrint.Click += new System.EventHandler(this.btnInvPrint_Click);
			// 
			// ultraGroupBox1
			// 
			this.ultraGroupBox1.Controls.Add(this.grid1);
			this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ultraGroupBox1.Location = new System.Drawing.Point(6, 6);
			this.ultraGroupBox1.Name = "ultraGroupBox1";
			this.ultraGroupBox1.Size = new System.Drawing.Size(1277, 282);
			this.ultraGroupBox1.TabIndex = 7;
			this.ultraGroupBox1.Text = "출고 실적 공통";
			// 
			// ultraSplitter1
			// 
			this.ultraSplitter1.BackColor = System.Drawing.Color.White;
			this.ultraSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ultraSplitter1.Location = new System.Drawing.Point(6, 288);
			this.ultraSplitter1.Name = "ultraSplitter1";
			this.ultraSplitter1.RestoreExtent = 324;
			this.ultraSplitter1.Size = new System.Drawing.Size(1277, 23);
			this.ultraSplitter1.TabIndex = 8;
			// 
			// ultraGroupBox2
			// 
			this.ultraGroupBox2.Controls.Add(this.grid2);
			this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ultraGroupBox2.Location = new System.Drawing.Point(6, 311);
			this.ultraGroupBox2.Name = "ultraGroupBox2";
			this.ultraGroupBox2.Size = new System.Drawing.Size(1277, 294);
			this.ultraGroupBox2.TabIndex = 9;
			this.ultraGroupBox2.Text = "출고 실적 상세";
			// 
			// grid2
			// 
			this.grid2.AutoResizeColumn = true;
			this.grid2.AutoUserColumn = true;
			this.grid2.ContextMenuCopyEnabled = true;
			this.grid2.ContextMenuDeleteEnabled = true;
			this.grid2.ContextMenuExcelEnabled = true;
			this.grid2.ContextMenuInsertEnabled = true;
			this.grid2.ContextMenuPasteEnabled = true;
			this.grid2.DeleteButtonEnable = true;
			appearance29.BackColor = System.Drawing.SystemColors.Window;
			appearance29.BorderColor = System.Drawing.SystemColors.InactiveCaption;
			this.grid2.DisplayLayout.Appearance = appearance29;
			this.grid2.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid2.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
			this.grid2.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty;
			appearance33.BackColor = System.Drawing.SystemColors.ActiveBorder;
			appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
			appearance33.BorderColor = System.Drawing.SystemColors.Window;
			this.grid2.DisplayLayout.GroupByBox.Appearance = appearance33;
			appearance34.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid2.DisplayLayout.GroupByBox.BandLabelAppearance = appearance34;
			this.grid2.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid2.DisplayLayout.GroupByBox.Hidden = true;
			appearance35.BackColor = System.Drawing.SystemColors.ControlLightLight;
			appearance35.BackColor2 = System.Drawing.SystemColors.Control;
			appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance35.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid2.DisplayLayout.GroupByBox.PromptAppearance = appearance35;
			this.grid2.DisplayLayout.MaxColScrollRegions = 1;
			this.grid2.DisplayLayout.MaxRowScrollRegions = 1;
			appearance36.BackColor = System.Drawing.SystemColors.Window;
			appearance36.ForeColor = System.Drawing.SystemColors.ControlText;
			this.grid2.DisplayLayout.Override.ActiveCellAppearance = appearance36;
			appearance43.BackColor = System.Drawing.SystemColors.Highlight;
			appearance43.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.grid2.DisplayLayout.Override.ActiveRowAppearance = appearance43;
			this.grid2.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
			this.grid2.DisplayLayout.Override.AllowMultiCellOperations = ((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)((((((((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.CopyWithHeaders) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Delete) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Undo) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Redo) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Reserved)));
			this.grid2.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
			this.grid2.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
			appearance44.BackColor = System.Drawing.SystemColors.Window;
			this.grid2.DisplayLayout.Override.CardAreaAppearance = appearance44;
			appearance57.BorderColor = System.Drawing.Color.Silver;
			appearance57.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
			this.grid2.DisplayLayout.Override.CellAppearance = appearance57;
			this.grid2.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
			this.grid2.DisplayLayout.Override.CellPadding = 0;
			appearance58.BackColor = System.Drawing.SystemColors.Control;
			appearance58.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance58.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
			appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance58.BorderColor = System.Drawing.SystemColors.Window;
			this.grid2.DisplayLayout.Override.GroupByRowAppearance = appearance58;
			this.grid2.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
			this.grid2.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
			appearance59.BackColor = System.Drawing.SystemColors.Window;
			appearance59.BorderColor = System.Drawing.Color.Silver;
			this.grid2.DisplayLayout.Override.RowAppearance = appearance59;
			this.grid2.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
			appearance61.BackColor = System.Drawing.SystemColors.ControlLight;
			this.grid2.DisplayLayout.Override.TemplateAddRowAppearance = appearance61;
			this.grid2.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
			this.grid2.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
			this.grid2.DisplayLayout.SelectionOverlayBorderThickness = 2;
			this.grid2.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
			this.grid2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid2.EnterNextRowEnable = true;
			this.grid2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.grid2.Location = new System.Drawing.Point(3, 24);
			this.grid2.Name = "grid2";
			this.grid2.Size = new System.Drawing.Size(1271, 267);
			this.grid2.TabIndex = 6;
			this.grid2.TabStop = false;
			this.grid2.Text = "grid2";
			this.grid2.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			this.grid2.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
			this.grid2.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
			this.grid2.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
			// 
			// WM_TradingManager
			// 
			this.ClientSize = new System.Drawing.Size(1295, 750);
			this.Name = "WM_TradingManager";
			this.Padding = new System.Windows.Forms.Padding(3);
			this.Text = "제품 출고 이력 확인 및 거래 명세서 발행";
			this.Load += new System.EventHandler(this.WM_TradingManager_Load);
			((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).EndInit();
			this.gbxHeader.ResumeLayout(false);
			this.gbxHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbxBody)).EndInit();
			this.gbxBody.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpStartDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpEndDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCarNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
			this.ultraGroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
			this.ultraGroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private DC00_Component.SLabel lblPlantCode;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboPlantCode;
        private DC00_Component.Grid grid1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtInvoiceNO;
        private DC00_Component.SLabel lblWorkerName_H;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCarNo;
		private DC00_Component.SLabel sLabel1;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtpStartDate;
		private DC00_Component.SLabel sLabel6;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtpEndDate;
		private DC00_Component.SLabel sLabel4;
		private Infragistics.Win.Misc.UltraButton btnInvPrint;
		private Infragistics.Win.Misc.UltraSplitter ultraSplitter1;
		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
		private DC00_Component.Grid grid2;
	}
}
