namespace KDT_Form
{
    partial class MM_StockMM
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
			Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
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
			this.sLabel1 = new DC00_Component.SLabel();
			this.cboPlantCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.sLabel3 = new DC00_Component.SLabel();
			this.txtLOTNO = new DC00_Component.STextBox(this.components);
			this.cboItemCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.sLabel5 = new DC00_Component.SLabel();
			this.grid1 = new DC00_Component.Grid(this.components);
			this.btnLOTMake = new Infragistics.Win.Misc.UltraButton();
			((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).BeginInit();
			this.gbxHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbxBody)).BeginInit();
			this.gbxBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLOTNO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboItemCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxHeader
			// 
			this.gbxHeader.ContentPadding.Bottom = 2;
			this.gbxHeader.ContentPadding.Left = 2;
			this.gbxHeader.ContentPadding.Right = 2;
			this.gbxHeader.ContentPadding.Top = 4;
			this.gbxHeader.Controls.Add(this.btnLOTMake);
			this.gbxHeader.Controls.Add(this.txtLOTNO);
			this.gbxHeader.Controls.Add(this.cboItemCode);
			this.gbxHeader.Controls.Add(this.sLabel5);
			this.gbxHeader.Controls.Add(this.sLabel3);
			this.gbxHeader.Controls.Add(this.cboPlantCode);
			this.gbxHeader.Controls.Add(this.sLabel1);
			this.gbxHeader.Size = new System.Drawing.Size(1313, 185);
			// 
			// gbxBody
			// 
			this.gbxBody.ContentPadding.Bottom = 4;
			this.gbxBody.ContentPadding.Left = 4;
			this.gbxBody.ContentPadding.Right = 4;
			this.gbxBody.ContentPadding.Top = 6;
			this.gbxBody.Controls.Add(this.grid1);
			this.gbxBody.Location = new System.Drawing.Point(0, 185);
			this.gbxBody.Size = new System.Drawing.Size(1313, 640);
			// 
			// sLabel1
			// 
			appearance18.FontData.BoldAsString = "False";
			appearance18.FontData.UnderlineAsString = "False";
			appearance18.ForeColor = System.Drawing.Color.Black;
			appearance18.TextHAlignAsString = "Right";
			appearance18.TextVAlignAsString = "Middle";
			this.sLabel1.Appearance = appearance18;
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
			appearance1.FontData.BoldAsString = "False";
			appearance1.FontData.UnderlineAsString = "False";
			appearance1.ForeColor = System.Drawing.Color.Black;
			appearance1.TextHAlignAsString = "Right";
			appearance1.TextVAlignAsString = "Middle";
			this.sLabel3.Appearance = appearance1;
			this.sLabel3.DbField = null;
			this.sLabel3.Font = new System.Drawing.Font("맑은 고딕", 12F);
			this.sLabel3.Location = new System.Drawing.Point(517, 113);
			this.sLabel3.Name = "sLabel3";
			this.sLabel3.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel3.Size = new System.Drawing.Size(113, 25);
			this.sLabel3.TabIndex = 4;
			this.sLabel3.Text = "LOT NO";
			// 
			// txtLOTNO
			// 
			appearance17.FontData.BoldAsString = "False";
			appearance17.FontData.UnderlineAsString = "False";
			appearance17.ForeColor = System.Drawing.Color.Black;
			this.txtLOTNO.Appearance = appearance17;
			this.txtLOTNO.Location = new System.Drawing.Point(648, 113);
			this.txtLOTNO.Name = "txtLOTNO";
			this.txtLOTNO.RequireFlag = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtLOTNO.RequirePop = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtLOTNO.Size = new System.Drawing.Size(142, 29);
			this.txtLOTNO.TabIndex = 5;
			// 
			// cboItemCode
			// 
			this.cboItemCode.Location = new System.Drawing.Point(103, 113);
			this.cboItemCode.Name = "cboItemCode";
			this.cboItemCode.Size = new System.Drawing.Size(383, 29);
			this.cboItemCode.TabIndex = 9;
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
			this.sLabel5.Location = new System.Drawing.Point(7, 113);
			this.sLabel5.Name = "sLabel5";
			this.sLabel5.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel5.Size = new System.Drawing.Size(81, 25);
			this.sLabel5.TabIndex = 8;
			this.sLabel5.Text = "품목";
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
			this.grid1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.grid1.Location = new System.Drawing.Point(6, 6);
			this.grid1.Name = "grid1";
			this.grid1.Size = new System.Drawing.Size(1301, 628);
			this.grid1.TabIndex = 0;
			this.grid1.Text = "grid1";
			this.grid1.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			this.grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
			this.grid1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
			this.grid1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
			// 
			// btnLOTMake
			// 
			this.btnLOTMake.Location = new System.Drawing.Point(825, 53);
			this.btnLOTMake.Name = "btnLOTMake";
			this.btnLOTMake.Size = new System.Drawing.Size(196, 88);
			this.btnLOTMake.TabIndex = 10;
			this.btnLOTMake.Text = "LOT 발행";
			this.btnLOTMake.Click += new System.EventHandler(this.btnLOTMake_Click);
			// 
			// MM_StockMM
			// 
			this.ClientSize = new System.Drawing.Size(1313, 825);
			this.Name = "MM_StockMM";
			this.Text = "구매자재 발주 및 입고";
			this.Load += new System.EventHandler(this.MM_StockMM_Load);
			((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).EndInit();
			this.gbxHeader.ResumeLayout(false);
			this.gbxHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbxBody)).EndInit();
			this.gbxBody.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLOTNO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboItemCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DC00_Component.SLabel sLabel1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboPlantCode;
        private DC00_Component.STextBox txtLOTNO;
        private DC00_Component.SLabel sLabel3;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboItemCode;
        private DC00_Component.SLabel sLabel5;
        private DC00_Component.Grid grid1;
		private Infragistics.Win.Misc.UltraButton btnLOTMake;
	}
}
