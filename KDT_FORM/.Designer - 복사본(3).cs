﻿namespace KDT_Form
{
    partial class PP_ActureOutPut
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
			this.sLabel1 = new DC00_Component.SLabel();
			this.cboPlantCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.sLabel3 = new DC00_Component.SLabel();
			this.txtINLotNo = new DC00_Component.STextBox(this.components);
			this.cboWorkcenter = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.sLabel5 = new DC00_Component.SLabel();
			this.grid1 = new DC00_Component.Grid(this.components);
			this.btnWorkerReg = new Infragistics.Win.Misc.UltraButton();
			this.sLabel2 = new DC00_Component.SLabel();
			this.txtWorkerID = new DC00_Component.SBtnTextEditor();
			this.txtWorkerName = new DC00_Component.STextBox(this.components);
			this.btnOrderNo = new Infragistics.Win.Misc.UltraButton();
			this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
			this.btnLOTIn = new Infragistics.Win.Misc.UltraButton();
			this.btnRunStop = new Infragistics.Win.Misc.UltraButton();
			this.sLabel4 = new DC00_Component.SLabel();
			this.txtProdQty = new DC00_Component.STextBox(this.components);
			this.sLabel6 = new DC00_Component.SLabel();
			this.txtBadQty = new DC00_Component.STextBox(this.components);
			this.btnProdReg = new Infragistics.Win.Misc.UltraButton();
			this.btnOrderClose = new Infragistics.Win.Misc.UltraButton();
			((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).BeginInit();
			this.gbxHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbxBody)).BeginInit();
			this.gbxBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtINLotNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboWorkcenter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWorkerID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWorkerName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
			this.ultraGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtProdQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBadQty)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxHeader
			// 
			this.gbxHeader.ContentPadding.Bottom = 2;
			this.gbxHeader.ContentPadding.Left = 2;
			this.gbxHeader.ContentPadding.Right = 2;
			this.gbxHeader.ContentPadding.Top = 4;
			this.gbxHeader.Controls.Add(this.btnOrderClose);
			this.gbxHeader.Controls.Add(this.btnProdReg);
			this.gbxHeader.Controls.Add(this.sLabel6);
			this.gbxHeader.Controls.Add(this.txtBadQty);
			this.gbxHeader.Controls.Add(this.sLabel4);
			this.gbxHeader.Controls.Add(this.btnRunStop);
			this.gbxHeader.Controls.Add(this.txtProdQty);
			this.gbxHeader.Controls.Add(this.ultraGroupBox1);
			this.gbxHeader.Controls.Add(this.btnOrderNo);
			this.gbxHeader.Controls.Add(this.txtWorkerName);
			this.gbxHeader.Controls.Add(this.txtWorkerID);
			this.gbxHeader.Controls.Add(this.sLabel2);
			this.gbxHeader.Controls.Add(this.btnWorkerReg);
			this.gbxHeader.Controls.Add(this.cboWorkcenter);
			this.gbxHeader.Controls.Add(this.sLabel5);
			this.gbxHeader.Controls.Add(this.cboPlantCode);
			this.gbxHeader.Controls.Add(this.sLabel1);
			this.gbxHeader.Size = new System.Drawing.Size(1425, 246);
			// 
			// gbxBody
			// 
			this.gbxBody.ContentPadding.Bottom = 4;
			this.gbxBody.ContentPadding.Left = 4;
			this.gbxBody.ContentPadding.Right = 4;
			this.gbxBody.ContentPadding.Top = 6;
			this.gbxBody.Controls.Add(this.grid1);
			this.gbxBody.Location = new System.Drawing.Point(0, 246);
			this.gbxBody.Size = new System.Drawing.Size(1425, 381);
			// 
			// sLabel1
			// 
			appearance4.FontData.BoldAsString = "False";
			appearance4.FontData.UnderlineAsString = "False";
			appearance4.ForeColor = System.Drawing.Color.Black;
			appearance4.TextHAlignAsString = "Right";
			appearance4.TextVAlignAsString = "Middle";
			this.sLabel1.Appearance = appearance4;
			this.sLabel1.DbField = null;
			this.sLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F);
			this.sLabel1.Location = new System.Drawing.Point(7, 37);
			this.sLabel1.Name = "sLabel1";
			this.sLabel1.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel1.Size = new System.Drawing.Size(81, 25);
			this.sLabel1.TabIndex = 0;
			this.sLabel1.Text = "공장";
			// 
			// cboPlantCode
			// 
			this.cboPlantCode.Location = new System.Drawing.Point(103, 37);
			this.cboPlantCode.Name = "cboPlantCode";
			this.cboPlantCode.Size = new System.Drawing.Size(126, 29);
			this.cboPlantCode.TabIndex = 1;
			// 
			// sLabel3
			// 
			appearance21.FontData.BoldAsString = "False";
			appearance21.FontData.UnderlineAsString = "False";
			appearance21.ForeColor = System.Drawing.Color.Black;
			appearance21.TextHAlignAsString = "Right";
			appearance21.TextVAlignAsString = "Middle";
			this.sLabel3.Appearance = appearance21;
			this.sLabel3.DbField = null;
			this.sLabel3.Font = new System.Drawing.Font("맑은 고딕", 12F);
			this.sLabel3.Location = new System.Drawing.Point(27, 30);
			this.sLabel3.Name = "sLabel3";
			this.sLabel3.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel3.Size = new System.Drawing.Size(82, 25);
			this.sLabel3.TabIndex = 4;
			this.sLabel3.Text = "LOT 번호";
			// 
			// txtINLotNo
			// 
			appearance23.FontData.BoldAsString = "False";
			appearance23.FontData.UnderlineAsString = "False";
			appearance23.ForeColor = System.Drawing.Color.Black;
			this.txtINLotNo.Appearance = appearance23;
			this.txtINLotNo.Location = new System.Drawing.Point(115, 27);
			this.txtINLotNo.Name = "txtINLotNo";
			this.txtINLotNo.RequireFlag = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtINLotNo.RequirePop = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtINLotNo.Size = new System.Drawing.Size(276, 29);
			this.txtINLotNo.TabIndex = 5;
			// 
			// cboWorkcenter
			// 
			this.cboWorkcenter.Location = new System.Drawing.Point(322, 37);
			this.cboWorkcenter.Name = "cboWorkcenter";
			this.cboWorkcenter.Size = new System.Drawing.Size(349, 29);
			this.cboWorkcenter.TabIndex = 9;
			this.cboWorkcenter.ValueChanged += new System.EventHandler(this.cboWorkcenter_ValueChanged);
			// 
			// sLabel5
			// 
			appearance3.FontData.BoldAsString = "False";
			appearance3.FontData.UnderlineAsString = "False";
			appearance3.ForeColor = System.Drawing.Color.Black;
			appearance3.TextHAlignAsString = "Right";
			appearance3.TextVAlignAsString = "Middle";
			this.sLabel5.Appearance = appearance3;
			this.sLabel5.DbField = null;
			this.sLabel5.Font = new System.Drawing.Font("맑은 고딕", 12F);
			this.sLabel5.Location = new System.Drawing.Point(235, 37);
			this.sLabel5.Name = "sLabel5";
			this.sLabel5.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel5.Size = new System.Drawing.Size(81, 25);
			this.sLabel5.TabIndex = 8;
			this.sLabel5.Text = "(1)작업장";
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
			appearance5.BackColor = System.Drawing.SystemColors.Window;
			appearance5.BorderColor = System.Drawing.SystemColors.InactiveCaption;
			this.grid1.DisplayLayout.Appearance = appearance5;
			this.grid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
			this.grid1.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty;
			appearance6.BackColor = System.Drawing.SystemColors.ActiveBorder;
			appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
			appearance6.BorderColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.GroupByBox.Appearance = appearance6;
			appearance7.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance7;
			this.grid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid1.DisplayLayout.GroupByBox.Hidden = true;
			appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight;
			appearance8.BackColor2 = System.Drawing.SystemColors.Control;
			appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance8.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid1.DisplayLayout.GroupByBox.PromptAppearance = appearance8;
			this.grid1.DisplayLayout.MaxColScrollRegions = 1;
			this.grid1.DisplayLayout.MaxRowScrollRegions = 1;
			appearance15.BackColor = System.Drawing.SystemColors.Window;
			appearance15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.grid1.DisplayLayout.Override.ActiveCellAppearance = appearance15;
			appearance9.BackColor = System.Drawing.SystemColors.Highlight;
			appearance9.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.grid1.DisplayLayout.Override.ActiveRowAppearance = appearance9;
			this.grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
			this.grid1.DisplayLayout.Override.AllowMultiCellOperations = ((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)(((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste)));
			this.grid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
			this.grid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
			appearance12.BackColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.Override.CardAreaAppearance = appearance12;
			appearance16.BorderColor = System.Drawing.Color.Silver;
			appearance16.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
			this.grid1.DisplayLayout.Override.CellAppearance = appearance16;
			this.grid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
			this.grid1.DisplayLayout.Override.CellPadding = 0;
			appearance14.BackColor = System.Drawing.SystemColors.Control;
			appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
			appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance14.BorderColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.Override.GroupByRowAppearance = appearance14;
			appearance10.TextHAlignAsString = "Left";
			this.grid1.DisplayLayout.Override.HeaderAppearance = appearance10;
			this.grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
			this.grid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
			appearance13.BackColor = System.Drawing.SystemColors.Window;
			appearance13.BorderColor = System.Drawing.Color.Silver;
			this.grid1.DisplayLayout.Override.RowAppearance = appearance13;
			this.grid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
			appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
			this.grid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance11;
			this.grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
			this.grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
			this.grid1.DisplayLayout.SelectionOverlayBorderThickness = 2;
			this.grid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
			this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid1.EnterNextRowEnable = true;
			this.grid1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.grid1.Location = new System.Drawing.Point(6, 6);
			this.grid1.Name = "grid1";
			this.grid1.Size = new System.Drawing.Size(1413, 369);
			this.grid1.TabIndex = 0;
			this.grid1.Text = "grid1";
			this.grid1.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			this.grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
			this.grid1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
			this.grid1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
			this.grid1.AfterRowActivate += new System.EventHandler(this.grid1_AfterRowActivate);
			// 
			// btnWorkerReg
			// 
			this.btnWorkerReg.Location = new System.Drawing.Point(1190, 26);
			this.btnWorkerReg.Name = "btnWorkerReg";
			this.btnWorkerReg.Size = new System.Drawing.Size(168, 53);
			this.btnWorkerReg.TabIndex = 10;
			this.btnWorkerReg.Text = "(2)작업자 등록";
			this.btnWorkerReg.Click += new System.EventHandler(this.btnWorkerReg_Click);
			// 
			// sLabel2
			// 
			appearance18.FontData.BoldAsString = "False";
			appearance18.FontData.UnderlineAsString = "False";
			appearance18.ForeColor = System.Drawing.Color.Black;
			appearance18.TextHAlignAsString = "Right";
			appearance18.TextVAlignAsString = "Middle";
			this.sLabel2.Appearance = appearance18;
			this.sLabel2.DbField = null;
			this.sLabel2.Font = new System.Drawing.Font("맑은 고딕", 10F);
			this.sLabel2.Location = new System.Drawing.Point(687, 40);
			this.sLabel2.Name = "sLabel2";
			this.sLabel2.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel2.Size = new System.Drawing.Size(56, 25);
			this.sLabel2.TabIndex = 11;
			this.sLabel2.Text = "작업자";
			// 
			// txtWorkerID
			// 
			appearance2.FontData.BoldAsString = "False";
			appearance2.FontData.UnderlineAsString = "False";
			appearance2.ForeColor = System.Drawing.Color.Black;
			this.txtWorkerID.Appearance = appearance2;
			this.txtWorkerID.btnImgType = DC00_Component.SBtnTextEditor.ButtonImgTypeEnum.Type1;
			this.txtWorkerID.btnWidth = 26;
			this.txtWorkerID.Location = new System.Drawing.Point(749, 37);
			this.txtWorkerID.Name = "txtWorkerID";
			this.txtWorkerID.RequireFlag = DC00_Component.SBtnTextEditor.RequireFlagEnum.NO;
			this.txtWorkerID.RequirePop = DC00_Component.SBtnTextEditor.RequireFlagEnum.NO;
			this.txtWorkerID.Size = new System.Drawing.Size(168, 29);
			this.txtWorkerID.TabIndex = 12;
			// 
			// txtWorkerName
			// 
			appearance19.FontData.BoldAsString = "False";
			appearance19.FontData.UnderlineAsString = "False";
			appearance19.ForeColor = System.Drawing.Color.Black;
			this.txtWorkerName.Appearance = appearance19;
			this.txtWorkerName.Location = new System.Drawing.Point(923, 36);
			this.txtWorkerName.Name = "txtWorkerName";
			this.txtWorkerName.RequireFlag = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtWorkerName.RequirePop = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtWorkerName.Size = new System.Drawing.Size(252, 29);
			this.txtWorkerName.TabIndex = 13;
			// 
			// btnOrderNo
			// 
			this.btnOrderNo.Location = new System.Drawing.Point(39, 72);
			this.btnOrderNo.Name = "btnOrderNo";
			this.btnOrderNo.Size = new System.Drawing.Size(217, 130);
			this.btnOrderNo.TabIndex = 14;
			this.btnOrderNo.Text = "(3)작업지시 선택";
			this.btnOrderNo.Click += new System.EventHandler(this.btnOrderNo_Click);
			// 
			// ultraGroupBox1
			// 
			this.ultraGroupBox1.Controls.Add(this.btnLOTIn);
			this.ultraGroupBox1.Controls.Add(this.sLabel3);
			this.ultraGroupBox1.Controls.Add(this.txtINLotNo);
			this.ultraGroupBox1.Location = new System.Drawing.Point(280, 72);
			this.ultraGroupBox1.Name = "ultraGroupBox1";
			this.ultraGroupBox1.Size = new System.Drawing.Size(414, 130);
			this.ultraGroupBox1.TabIndex = 15;
			this.ultraGroupBox1.Text = "LOT 투입";
			// 
			// btnLOTIn
			// 
			this.btnLOTIn.Location = new System.Drawing.Point(174, 75);
			this.btnLOTIn.Name = "btnLOTIn";
			this.btnLOTIn.Size = new System.Drawing.Size(217, 39);
			this.btnLOTIn.TabIndex = 16;
			this.btnLOTIn.Text = "(4) LOT투입";
			this.btnLOTIn.Click += new System.EventHandler(this.btnLOTIn_Click);
			// 
			// btnRunStop
			// 
			this.btnRunStop.Location = new System.Drawing.Point(700, 72);
			this.btnRunStop.Name = "btnRunStop";
			this.btnRunStop.Size = new System.Drawing.Size(202, 130);
			this.btnRunStop.TabIndex = 16;
			this.btnRunStop.Text = "(5)가동";
			this.btnRunStop.Click += new System.EventHandler(this.btnRunStop_Click);
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
			this.sLabel4.Font = new System.Drawing.Font("맑은 고딕", 10F);
			this.sLabel4.Location = new System.Drawing.Point(918, 79);
			this.sLabel4.Name = "sLabel4";
			this.sLabel4.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel4.Size = new System.Drawing.Size(78, 25);
			this.sLabel4.TabIndex = 17;
			this.sLabel4.Text = "양품 수량";
			// 
			// txtProdQty
			// 
			appearance22.FontData.BoldAsString = "False";
			appearance22.FontData.UnderlineAsString = "False";
			appearance22.ForeColor = System.Drawing.Color.Black;
			this.txtProdQty.Appearance = appearance22;
			this.txtProdQty.Location = new System.Drawing.Point(1002, 72);
			this.txtProdQty.Name = "txtProdQty";
			this.txtProdQty.RequireFlag = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtProdQty.RequirePop = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtProdQty.Size = new System.Drawing.Size(173, 29);
			this.txtProdQty.TabIndex = 18;
			// 
			// sLabel6
			// 
			appearance1.FontData.BoldAsString = "False";
			appearance1.FontData.UnderlineAsString = "False";
			appearance1.ForeColor = System.Drawing.Color.Black;
			appearance1.TextHAlignAsString = "Right";
			appearance1.TextVAlignAsString = "Middle";
			this.sLabel6.Appearance = appearance1;
			this.sLabel6.DbField = null;
			this.sLabel6.Font = new System.Drawing.Font("맑은 고딕", 10F);
			this.sLabel6.Location = new System.Drawing.Point(918, 110);
			this.sLabel6.Name = "sLabel6";
			this.sLabel6.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel6.Size = new System.Drawing.Size(78, 25);
			this.sLabel6.TabIndex = 19;
			this.sLabel6.Text = "불량 수량";
			// 
			// txtBadQty
			// 
			appearance17.FontData.BoldAsString = "False";
			appearance17.FontData.UnderlineAsString = "False";
			appearance17.ForeColor = System.Drawing.Color.Black;
			this.txtBadQty.Appearance = appearance17;
			this.txtBadQty.Location = new System.Drawing.Point(1002, 107);
			this.txtBadQty.Name = "txtBadQty";
			this.txtBadQty.RequireFlag = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtBadQty.RequirePop = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtBadQty.Size = new System.Drawing.Size(173, 29);
			this.txtBadQty.TabIndex = 20;
			// 
			// btnProdReg
			// 
			this.btnProdReg.Location = new System.Drawing.Point(923, 163);
			this.btnProdReg.Name = "btnProdReg";
			this.btnProdReg.Size = new System.Drawing.Size(252, 39);
			this.btnProdReg.TabIndex = 17;
			this.btnProdReg.Text = "(6) 생산실적 등록";
			this.btnProdReg.Click += new System.EventHandler(this.btnProdReg_Click);
			// 
			// btnOrderClose
			// 
			this.btnOrderClose.Location = new System.Drawing.Point(1190, 85);
			this.btnOrderClose.Name = "btnOrderClose";
			this.btnOrderClose.Size = new System.Drawing.Size(202, 117);
			this.btnOrderClose.TabIndex = 21;
			this.btnOrderClose.Text = "(7)작업지시종료";
			this.btnOrderClose.Click += new System.EventHandler(this.btnOrderClose_Click);
			// 
			// PP_ActureOutPut
			// 
			this.ClientSize = new System.Drawing.Size(1425, 627);
			this.Name = "PP_ActureOutPut";
			this.Text = "생산 실적 등록";
			this.Load += new System.EventHandler(this.PP_ActureOutPut_Load);
			((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).EndInit();
			this.gbxHeader.ResumeLayout(false);
			this.gbxHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbxBody)).EndInit();
			this.gbxBody.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtINLotNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboWorkcenter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWorkerID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWorkerName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
			this.ultraGroupBox1.ResumeLayout(false);
			this.ultraGroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtProdQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBadQty)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DC00_Component.SLabel sLabel1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboPlantCode;
        private DC00_Component.STextBox txtINLotNo;
        private DC00_Component.SLabel sLabel3;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboWorkcenter;
        private DC00_Component.SLabel sLabel5;
        private DC00_Component.Grid grid1;
		private Infragistics.Win.Misc.UltraButton btnWorkerReg;
		private DC00_Component.SLabel sLabel2;
		private DC00_Component.STextBox txtWorkerName;
		private DC00_Component.SBtnTextEditor txtWorkerID;
		private Infragistics.Win.Misc.UltraButton btnOrderNo;
		private Infragistics.Win.Misc.UltraButton btnRunStop;
		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
		private Infragistics.Win.Misc.UltraButton btnLOTIn;
		private Infragistics.Win.Misc.UltraButton btnOrderClose;
		private Infragistics.Win.Misc.UltraButton btnProdReg;
		private DC00_Component.SLabel sLabel6;
		private DC00_Component.STextBox txtBadQty;
		private DC00_Component.SLabel sLabel4;
		private DC00_Component.STextBox txtProdQty;
	}
}
