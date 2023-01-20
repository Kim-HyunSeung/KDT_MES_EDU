namespace KDT_Form
{
    partial class PP_WorkerPerProd
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
			Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
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
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			this.sLabel1 = new DC00_Component.SLabel();
			this.cboPlantCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.sLabel5 = new DC00_Component.SLabel();
			this.grid1 = new DC00_Component.Grid(this.components);
			this.dtpStartDate = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.sLabel6 = new DC00_Component.SLabel();
			this.dtpEndDate = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.txtWorkerId = new DC00_Component.SBtnTextEditor();
			this.txtWorkerName = new DC00_Component.STextBox(this.components);
			this.sLabel2 = new DC00_Component.SLabel();
			((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).BeginInit();
			this.gbxHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbxBody)).BeginInit();
			this.gbxBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpStartDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpEndDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWorkerId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWorkerName)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxHeader
			// 
			this.gbxHeader.ContentPadding.Bottom = 2;
			this.gbxHeader.ContentPadding.Left = 2;
			this.gbxHeader.ContentPadding.Right = 2;
			this.gbxHeader.ContentPadding.Top = 4;
			this.gbxHeader.Controls.Add(this.sLabel2);
			this.gbxHeader.Controls.Add(this.txtWorkerName);
			this.gbxHeader.Controls.Add(this.txtWorkerId);
			this.gbxHeader.Controls.Add(this.dtpStartDate);
			this.gbxHeader.Controls.Add(this.dtpEndDate);
			this.gbxHeader.Controls.Add(this.sLabel5);
			this.gbxHeader.Controls.Add(this.cboPlantCode);
			this.gbxHeader.Controls.Add(this.sLabel1);
			this.gbxHeader.Controls.Add(this.sLabel6);
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
			this.sLabel1.Location = new System.Drawing.Point(6, 73);
			this.sLabel1.Name = "sLabel1";
			this.sLabel1.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel1.Size = new System.Drawing.Size(81, 25);
			this.sLabel1.TabIndex = 0;
			this.sLabel1.Text = "공장";
			// 
			// cboPlantCode
			// 
			this.cboPlantCode.Location = new System.Drawing.Point(93, 72);
			this.cboPlantCode.Name = "cboPlantCode";
			this.cboPlantCode.Size = new System.Drawing.Size(126, 29);
			this.cboPlantCode.TabIndex = 1;
			// 
			// sLabel5
			// 
			appearance22.FontData.BoldAsString = "False";
			appearance22.FontData.UnderlineAsString = "False";
			appearance22.ForeColor = System.Drawing.Color.Black;
			appearance22.TextHAlignAsString = "Right";
			appearance22.TextVAlignAsString = "Middle";
			this.sLabel5.Appearance = appearance22;
			this.sLabel5.DbField = null;
			this.sLabel5.Font = new System.Drawing.Font("맑은 고딕", 12F);
			this.sLabel5.Location = new System.Drawing.Point(225, 73);
			this.sLabel5.Name = "sLabel5";
			this.sLabel5.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel5.Size = new System.Drawing.Size(81, 25);
			this.sLabel5.TabIndex = 8;
			this.sLabel5.Text = "작업자";
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
			this.grid1.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.grid1_InitializeLayout);
			this.grid1.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.grid1_InitializeRow);
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.DateButtons.Add(dateButton1);
			this.dtpStartDate.Location = new System.Drawing.Point(785, 68);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.NonAutoSizeHeight = 26;
			this.dtpStartDate.Size = new System.Drawing.Size(121, 26);
			this.dtpStartDate.TabIndex = 14;
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
			this.sLabel6.Location = new System.Drawing.Point(860, 68);
			this.sLabel6.Name = "sLabel6";
			this.sLabel6.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel6.Size = new System.Drawing.Size(81, 25);
			this.sLabel6.TabIndex = 16;
			this.sLabel6.Text = "~";
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.DateButtons.Add(dateButton2);
			this.dtpEndDate.Location = new System.Drawing.Point(947, 69);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.NonAutoSizeHeight = 26;
			this.dtpEndDate.Size = new System.Drawing.Size(121, 26);
			this.dtpEndDate.TabIndex = 15;
			// 
			// txtWorkerId
			// 
			appearance2.FontData.BoldAsString = "False";
			appearance2.FontData.UnderlineAsString = "False";
			appearance2.ForeColor = System.Drawing.Color.Black;
			this.txtWorkerId.Appearance = appearance2;
			this.txtWorkerId.btnImgType = DC00_Component.SBtnTextEditor.ButtonImgTypeEnum.Type1;
			this.txtWorkerId.btnWidth = 26;
			this.txtWorkerId.Location = new System.Drawing.Point(312, 70);
			this.txtWorkerId.Name = "txtWorkerId";
			this.txtWorkerId.RequireFlag = DC00_Component.SBtnTextEditor.RequireFlagEnum.NO;
			this.txtWorkerId.RequirePop = DC00_Component.SBtnTextEditor.RequireFlagEnum.NO;
			this.txtWorkerId.Size = new System.Drawing.Size(168, 29);
			this.txtWorkerId.TabIndex = 17;
			// 
			// txtWorkerName
			// 
			appearance17.FontData.BoldAsString = "False";
			appearance17.FontData.UnderlineAsString = "False";
			appearance17.ForeColor = System.Drawing.Color.Black;
			this.txtWorkerName.Appearance = appearance17;
			this.txtWorkerName.Location = new System.Drawing.Point(486, 69);
			this.txtWorkerName.Name = "txtWorkerName";
			this.txtWorkerName.RequireFlag = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtWorkerName.RequirePop = DC00_Component.STextBox.RequireFlagEnum.NO;
			this.txtWorkerName.Size = new System.Drawing.Size(142, 29);
			this.txtWorkerName.TabIndex = 18;
			// 
			// sLabel2
			// 
			appearance3.FontData.BoldAsString = "False";
			appearance3.FontData.UnderlineAsString = "False";
			appearance3.ForeColor = System.Drawing.Color.Black;
			appearance3.TextHAlignAsString = "Right";
			appearance3.TextVAlignAsString = "Middle";
			this.sLabel2.Appearance = appearance3;
			this.sLabel2.DbField = null;
			this.sLabel2.Font = new System.Drawing.Font("맑은 고딕", 10F);
			this.sLabel2.Location = new System.Drawing.Point(669, 69);
			this.sLabel2.Name = "sLabel2";
			this.sLabel2.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel2.Size = new System.Drawing.Size(81, 25);
			this.sLabel2.TabIndex = 19;
			this.sLabel2.Text = "생산 일자";
			// 
			// PP_WorkerPerProd
			// 
			this.ClientSize = new System.Drawing.Size(1313, 825);
			this.Name = "PP_WorkerPerProd";
			this.Text = "작업자 일별 생산 실적";
			this.Load += new System.EventHandler(this.PP_WorkerPerProd_Load);
			((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).EndInit();
			this.gbxHeader.ResumeLayout(false);
			this.gbxHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbxBody)).EndInit();
			this.gbxBody.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpStartDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpEndDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWorkerId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWorkerName)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DC00_Component.SLabel sLabel1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboPlantCode;
        private DC00_Component.SLabel sLabel5;
        private DC00_Component.Grid grid1;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtpStartDate;
        private DC00_Component.SLabel sLabel6;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtpEndDate;
		private DC00_Component.STextBox txtWorkerName;
		private DC00_Component.SBtnTextEditor txtWorkerId;
		private DC00_Component.SLabel sLabel2;
	}
}
