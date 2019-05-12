namespace PatchMaster
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_packagesourcePath = new System.Windows.Forms.TextBox();
            this.tb_packageFolder = new System.Windows.Forms.TextBox();
            this.dgv_Transcript = new System.Windows.Forms.DataGridView();
            this.c_transcript_deviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_transcript_Architecture = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_transcript_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_transcript_Classifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_transcript_Languages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_transcript_includeRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_transcript_ignoreBuilds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_ooc_Tag = new System.Windows.Forms.TextBox();
            this.dgv_Deployments = new System.Windows.Forms.DataGridView();
            this.c_deployments_DeviceType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_deployment_coltarget = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_deployment_depTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_deployment_availReq = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_deployment_availdate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_deployment_availTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_deployment_deadlinedateOffset = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_deployment_deadlineTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_availablePatches = new System.Windows.Forms.DataGridView();
            this.c_ap_deviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ap_PatchKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ap_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_app_Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ap_Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ap_Architecture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ap_DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ap_dateReleased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ignorePatches = new System.Windows.Forms.DataGridView();
            this.c_ignorepatches_KBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ignorepatches_LocalizedDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ignorepatches_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ignorepatches_Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmt_Patch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_ignorePatch = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_SecurityScopes = new System.Windows.Forms.DataGridView();
            this.c_scoping_deviceType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_scoping_Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_scoping_Scope = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tb_Config = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.b_openLog = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nud_downloadRetry = new System.Windows.Forms.NumericUpDown();
            this.gb_namingBar = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.flp_namingSelections = new System.Windows.Forms.FlowLayoutPanel();
            this.tb_addTextbox = new System.Windows.Forms.TextBox();
            this.b_addDay = new System.Windows.Forms.Button();
            this.b_addMonth = new System.Windows.Forms.Button();
            this.b_addYear = new System.Windows.Forms.Button();
            this.b_addClassification = new System.Windows.Forms.Button();
            this.b_addArchitecture = new System.Windows.Forms.Button();
            this.cb_patchnamingDelimiter = new System.Windows.Forms.ComboBox();
            this.b_addReporting = new System.Windows.Forms.Button();
            this.b_addOOC = new System.Windows.Forms.Button();
            this.cb_unlocknamingBar = new System.Windows.Forms.CheckBox();
            this.b_addLanguage = new System.Windows.Forms.Button();
            this.b_addProduct = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cb_rollupOffice = new System.Windows.Forms.CheckBox();
            this.cb_rollupserverOS = new System.Windows.Forms.CheckBox();
            this.cb_rollupclientOS = new System.Windows.Forms.CheckBox();
            this.cb_createreportingSUGS = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cb_deployment_RandomizationEnabled = new System.Windows.Forms.CheckBox();
            this.b_Debug = new System.Windows.Forms.Button();
            this.cb_deployment_overrideserviceWindows = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_deployment_statemessagePriority = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_deployment_statemessageVerbosity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_deploymentdeviceGroup = new System.Windows.Forms.ComboBox();
            this.cb_deployment_useruiExperience = new System.Windows.Forms.CheckBox();
            this.cb_deployment_raisemomalertsonFailure = new System.Windows.Forms.CheckBox();
            this.cb_deployment_useutcTimes = new System.Windows.Forms.CheckBox();
            this.cb_deployment_senddetailednonCompliance = new System.Windows.Forms.CheckBox();
            this.cb_deployment_notifyUser = new System.Windows.Forms.CheckBox();
            this.cb_deployment_logtowinEvent = new System.Windows.Forms.CheckBox();
            this.cb_deployment_limitstatemsgverbosity = new System.Windows.Forms.CheckBox();
            this.cb_deployment_disablemomAlerts = new System.Windows.Forms.CheckBox();
            this.cb_deployment_useBranchcache = new System.Windows.Forms.CheckBox();
            this.cb_deployment_enableWOL = new System.Windows.Forms.CheckBox();
            this.cb_deployment_allowMetered = new System.Windows.Forms.CheckBox();
            this.cb_deployment_usemsUpdates = new System.Windows.Forms.CheckBox();
            this.cb_deployment_defaultFallback = new System.Windows.Forms.CheckBox();
            this.cb_deployment_downloadNeighbour = new System.Windows.Forms.CheckBox();
            this.cb_deployment_Evaluation = new System.Windows.Forms.CheckBox();
            this.cb_deployment_commitFilter = new System.Windows.Forms.CheckBox();
            this.cb_deployment_supressWorkstations = new System.Windows.Forms.CheckBox();
            this.cb_deployment_supressServers = new System.Windows.Forms.CheckBox();
            this.cb_deployment_deadlinerestart = new System.Windows.Forms.CheckBox();
            this.cb_deployment_delayEnforcement = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.b_createPath = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pb_Tom = new System.Windows.Forms.PictureBox();
            this.cb_timemachine_Day = new System.Windows.Forms.ComboBox();
            this.cb_timeMachine = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_timemachine_Month = new System.Windows.Forms.ComboBox();
            this.cb_timemachine_Year = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_removeDP = new System.Windows.Forms.Button();
            this.dgv_distributionPoints = new System.Windows.Forms.DataGridView();
            this.c_dp_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_dp_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_dp_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_dp_Sitecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_dp_nalPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_dpList = new System.Windows.Forms.ComboBox();
            this.b_addDP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_deviceType = new System.Windows.Forms.ListBox();
            this.b_devicetypeAdd = new System.Windows.Forms.Button();
            this.tb_deviceType = new System.Windows.Forms.TextBox();
            this.b_devicetypeRemove = new System.Windows.Forms.Button();
            this.tb_Rules = new System.Windows.Forms.TabPage();
            this.b_removeselectedRule = new System.Windows.Forms.Button();
            this.tb_Deployments = new System.Windows.Forms.TabPage();
            this.b_removeDeployment = new System.Windows.Forms.Button();
            this.tb_SecurityScopes = new System.Windows.Forms.TabPage();
            this.b_removesecurityScope = new System.Windows.Forms.Button();
            this.tb_AvailablePatches = new System.Windows.Forms.TabPage();
            this.cb_forceScan = new System.Windows.Forms.CheckBox();
            this.cb_runsumCleanup = new System.Windows.Forms.CheckBox();
            this.sc_View = new System.Windows.Forms.SplitContainer();
            this.dgv_Preview = new System.Windows.Forms.DataGridView();
            this.c_preview_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_preview_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_preview_TotalItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_preview_deviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_createObjects = new System.Windows.Forms.Button();
            this.b_buildPreview = new System.Windows.Forms.Button();
            this.l_totalRows = new System.Windows.Forms.Label();
            this.b_checkforPatches = new System.Windows.Forms.Button();
            this.tb_IgnorePatches = new System.Windows.Forms.TabPage();
            this.tb_SUMaint = new System.Windows.Forms.TabPage();
            this.b_locatesupersedPatches = new System.Windows.Forms.Button();
            this.dgv_supersededPatches = new System.Windows.Forms.DataGridView();
            this.c_supersededPatch_SUG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_supersededPatch_SUGCIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_supersededPatch_PatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_supersededPatch_PatchKBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_supersededPatch_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_removesupersededPatches = new System.Windows.Forms.Button();
            this.tb_WSUS = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tb_wsusPort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_wsusName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_wsus_dryRun = new System.Windows.Forms.CheckBox();
            this.b_invokewsusCleanup = new System.Windows.Forms.Button();
            this.b_getwsusPatches = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.dgv_wsus_Patches = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_wsus_Text = new System.Windows.Forms.TextBox();
            this.cb_wsusAction = new System.Windows.Forms.ComboBox();
            this.cb_wsus_Type = new System.Windows.Forms.ComboBox();
            this.b_adddwsusRule = new System.Windows.Forms.Button();
            this.dgv_cmdCollection = new System.Windows.Forms.DataGridView();
            this.c_cmdCollection_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_cmdCollection_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_wsus_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Log = new System.Windows.Forms.TabPage();
            this.dgv_Logging = new System.Windows.Forms.DataGridView();
            this.c_log_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_About = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.l_Freeware = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_bigLogo = new System.Windows.Forms.PictureBox();
            this.rtb_tAbout = new System.Windows.Forms.RichTextBox();
            this.pb_waitImage = new System.Windows.Forms.PictureBox();
            this.cmt_removeignoredPatch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rptsmi_removeignoredPatch = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transcript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Deployments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_availablePatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ignorePatches)).BeginInit();
            this.cmt_Patch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SecurityScopes)).BeginInit();
            this.tc_Main.SuspendLayout();
            this.tb_Config.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_downloadRetry)).BeginInit();
            this.gb_namingBar.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Tom)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_distributionPoints)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tb_Rules.SuspendLayout();
            this.tb_Deployments.SuspendLayout();
            this.tb_SecurityScopes.SuspendLayout();
            this.tb_AvailablePatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_View)).BeginInit();
            this.sc_View.Panel1.SuspendLayout();
            this.sc_View.Panel2.SuspendLayout();
            this.sc_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Preview)).BeginInit();
            this.tb_IgnorePatches.SuspendLayout();
            this.tb_SUMaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supersededPatches)).BeginInit();
            this.tb_WSUS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_wsus_Patches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmdCollection)).BeginInit();
            this.tb_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Logging)).BeginInit();
            this.tb_About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bigLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_waitImage)).BeginInit();
            this.cmt_removeignoredPatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Package Source Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(416, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Package Folder";
            // 
            // tb_packagesourcePath
            // 
            this.tb_packagesourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_packagesourcePath.Location = new System.Drawing.Point(22, 32);
            this.tb_packagesourcePath.Name = "tb_packagesourcePath";
            this.tb_packagesourcePath.Size = new System.Drawing.Size(385, 20);
            this.tb_packagesourcePath.TabIndex = 6;
            this.tb_packagesourcePath.Text = "\\\\<SERVER><SMBSHARE><PATH>";
            this.tb_packagesourcePath.TextChanged += new System.EventHandler(this.tb_packagesourcePath_TextChanged);
            // 
            // tb_packageFolder
            // 
            this.tb_packageFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_packageFolder.Location = new System.Drawing.Point(416, 32);
            this.tb_packageFolder.Name = "tb_packageFolder";
            this.tb_packageFolder.Size = new System.Drawing.Size(127, 20);
            this.tb_packageFolder.TabIndex = 7;
            this.tb_packageFolder.Text = "AutoPatches";
            this.tb_packageFolder.TextChanged += new System.EventHandler(this.tb_packageFolder_TextChanged);
            // 
            // dgv_Transcript
            // 
            this.dgv_Transcript.AllowUserToOrderColumns = true;
            this.dgv_Transcript.AllowUserToResizeRows = false;
            this.dgv_Transcript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Transcript.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Transcript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Transcript.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_transcript_deviceType,
            this.c_transcript_Architecture,
            this.c_transcript_Product,
            this.c_transcript_Classifications,
            this.c_transcript_Languages,
            this.c_transcript_includeRule,
            this.c_transcript_ignoreBuilds});
            this.dgv_Transcript.Location = new System.Drawing.Point(3, 3);
            this.dgv_Transcript.Name = "dgv_Transcript";
            this.dgv_Transcript.Size = new System.Drawing.Size(1062, 533);
            this.dgv_Transcript.TabIndex = 8;
            this.dgv_Transcript.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Transcript_CellClick);
            this.dgv_Transcript.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Transcript_CellContentClick);
            this.dgv_Transcript.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Transcript_CellEndEdit);
            this.dgv_Transcript.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_Transcript_DataError);
            this.dgv_Transcript.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Transcript_RowLeave);
            // 
            // c_transcript_deviceType
            // 
            this.c_transcript_deviceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_transcript_deviceType.HeaderText = "Device Group";
            this.c_transcript_deviceType.Name = "c_transcript_deviceType";
            this.c_transcript_deviceType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_transcript_deviceType.Width = 98;
            // 
            // c_transcript_Architecture
            // 
            this.c_transcript_Architecture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_transcript_Architecture.HeaderText = "Architecture";
            this.c_transcript_Architecture.Items.AddRange(new object[] {
            "x64",
            "x86",
            "Both"});
            this.c_transcript_Architecture.Name = "c_transcript_Architecture";
            this.c_transcript_Architecture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_transcript_Architecture.Width = 89;
            // 
            // c_transcript_Product
            // 
            this.c_transcript_Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_transcript_Product.HeaderText = "Products";
            this.c_transcript_Product.Name = "c_transcript_Product";
            this.c_transcript_Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_transcript_Product.Width = 74;
            // 
            // c_transcript_Classifications
            // 
            this.c_transcript_Classifications.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_transcript_Classifications.HeaderText = "Classifications";
            this.c_transcript_Classifications.Name = "c_transcript_Classifications";
            this.c_transcript_Classifications.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_transcript_Classifications.Width = 98;
            // 
            // c_transcript_Languages
            // 
            this.c_transcript_Languages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_transcript_Languages.HeaderText = "Languages";
            this.c_transcript_Languages.Name = "c_transcript_Languages";
            this.c_transcript_Languages.Width = 85;
            // 
            // c_transcript_includeRule
            // 
            this.c_transcript_includeRule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_transcript_includeRule.HeaderText = "Include";
            this.c_transcript_includeRule.Name = "c_transcript_includeRule";
            this.c_transcript_includeRule.Width = 67;
            // 
            // c_transcript_ignoreBuilds
            // 
            this.c_transcript_ignoreBuilds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_transcript_ignoreBuilds.HeaderText = "Exclude";
            this.c_transcript_ignoreBuilds.Name = "c_transcript_ignoreBuilds";
            this.c_transcript_ignoreBuilds.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_transcript_ignoreBuilds.Width = 70;
            // 
            // tb_ooc_Tag
            // 
            this.tb_ooc_Tag.Location = new System.Drawing.Point(10, 22);
            this.tb_ooc_Tag.Name = "tb_ooc_Tag";
            this.tb_ooc_Tag.Size = new System.Drawing.Size(150, 20);
            this.tb_ooc_Tag.TabIndex = 26;
            this.tb_ooc_Tag.Text = "OOC";
            this.tb_ooc_Tag.TextChanged += new System.EventHandler(this.tb_ooc_Tag_TextChanged);
            // 
            // dgv_Deployments
            // 
            this.dgv_Deployments.AllowUserToOrderColumns = true;
            this.dgv_Deployments.AllowUserToResizeRows = false;
            this.dgv_Deployments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Deployments.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Deployments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Deployments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_deployments_DeviceType,
            this.c_deployment_coltarget,
            this.c_deployment_depTag,
            this.c_deployment_availReq,
            this.c_deployment_availdate,
            this.c_deployment_availTime,
            this.c_deployment_deadlinedateOffset,
            this.c_deployment_deadlineTime});
            this.dgv_Deployments.Location = new System.Drawing.Point(3, 3);
            this.dgv_Deployments.Name = "dgv_Deployments";
            this.dgv_Deployments.Size = new System.Drawing.Size(1062, 533);
            this.dgv_Deployments.TabIndex = 31;
            this.dgv_Deployments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Deployments_CellClick);
            this.dgv_Deployments.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_Deployments_DataError);
            this.dgv_Deployments.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Deployments_RowLeave);
            // 
            // c_deployments_DeviceType
            // 
            this.c_deployments_DeviceType.HeaderText = "Device Group";
            this.c_deployments_DeviceType.Items.AddRange(new object[] {
            "Client",
            "Server"});
            this.c_deployments_DeviceType.Name = "c_deployments_DeviceType";
            this.c_deployments_DeviceType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_deployments_DeviceType.Sorted = true;
            this.c_deployments_DeviceType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_deployments_DeviceType.Width = 90;
            // 
            // c_deployment_coltarget
            // 
            this.c_deployment_coltarget.HeaderText = "Target Collection";
            this.c_deployment_coltarget.Items.AddRange(new object[] {
            "1",
            "2"});
            this.c_deployment_coltarget.Name = "c_deployment_coltarget";
            this.c_deployment_coltarget.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_deployment_coltarget.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_deployment_coltarget.Width = 180;
            // 
            // c_deployment_depTag
            // 
            this.c_deployment_depTag.HeaderText = "Deployment Tag";
            this.c_deployment_depTag.Name = "c_deployment_depTag";
            this.c_deployment_depTag.Visible = false;
            // 
            // c_deployment_availReq
            // 
            this.c_deployment_availReq.HeaderText = "Intent";
            this.c_deployment_availReq.Items.AddRange(new object[] {
            "Available",
            "Required"});
            this.c_deployment_availReq.Name = "c_deployment_availReq";
            this.c_deployment_availReq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_deployment_availReq.Width = 80;
            // 
            // c_deployment_availdate
            // 
            this.c_deployment_availdate.HeaderText = "Available Date Offset (Days)";
            this.c_deployment_availdate.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.c_deployment_availdate.Name = "c_deployment_availdate";
            this.c_deployment_availdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_deployment_availdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_deployment_availdate.Width = 180;
            // 
            // c_deployment_availTime
            // 
            this.c_deployment_availTime.HeaderText = "Available Date Offset (Time)";
            this.c_deployment_availTime.Name = "c_deployment_availTime";
            // 
            // c_deployment_deadlinedateOffset
            // 
            this.c_deployment_deadlinedateOffset.HeaderText = "Deadline Date Offset (Days)";
            this.c_deployment_deadlinedateOffset.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.c_deployment_deadlinedateOffset.Name = "c_deployment_deadlinedateOffset";
            this.c_deployment_deadlinedateOffset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_deployment_deadlinedateOffset.Width = 180;
            // 
            // c_deployment_deadlineTime
            // 
            this.c_deployment_deadlineTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_deployment_deadlineTime.HeaderText = "Deadline Date Offset (Time)";
            this.c_deployment_deadlineTime.MinimumWidth = 100;
            this.c_deployment_deadlineTime.Name = "c_deployment_deadlineTime";
            // 
            // dgv_availablePatches
            // 
            this.dgv_availablePatches.AllowUserToAddRows = false;
            this.dgv_availablePatches.AllowUserToDeleteRows = false;
            this.dgv_availablePatches.AllowUserToOrderColumns = true;
            this.dgv_availablePatches.AllowUserToResizeRows = false;
            this.dgv_availablePatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_availablePatches.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_availablePatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_availablePatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_ap_deviceType,
            this.c_ap_PatchKB,
            this.c_ap_Name,
            this.c_app_Products,
            this.c_ap_Classification,
            this.c_ap_Architecture,
            this.c_ap_DateCreated,
            this.c_ap_dateReleased});
            this.dgv_availablePatches.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_availablePatches.Location = new System.Drawing.Point(3, 3);
            this.dgv_availablePatches.Name = "dgv_availablePatches";
            this.dgv_availablePatches.ReadOnly = true;
            this.dgv_availablePatches.RowHeadersVisible = false;
            this.dgv_availablePatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_availablePatches.Size = new System.Drawing.Size(1057, 326);
            this.dgv_availablePatches.TabIndex = 32;
            this.dgv_availablePatches.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_availablePatches_CellContentDoubleClick);
            // 
            // c_ap_deviceType
            // 
            this.c_ap_deviceType.HeaderText = "Device Group";
            this.c_ap_deviceType.Name = "c_ap_deviceType";
            this.c_ap_deviceType.ReadOnly = true;
            this.c_ap_deviceType.Width = 70;
            // 
            // c_ap_PatchKB
            // 
            this.c_ap_PatchKB.HeaderText = "Article ID";
            this.c_ap_PatchKB.Name = "c_ap_PatchKB";
            this.c_ap_PatchKB.ReadOnly = true;
            this.c_ap_PatchKB.Width = 90;
            // 
            // c_ap_Name
            // 
            this.c_ap_Name.HeaderText = "Description";
            this.c_ap_Name.Name = "c_ap_Name";
            this.c_ap_Name.ReadOnly = true;
            this.c_ap_Name.Width = 150;
            // 
            // c_app_Products
            // 
            this.c_app_Products.HeaderText = "Product";
            this.c_app_Products.Name = "c_app_Products";
            this.c_app_Products.ReadOnly = true;
            this.c_app_Products.Width = 80;
            // 
            // c_ap_Classification
            // 
            this.c_ap_Classification.HeaderText = "Classification";
            this.c_ap_Classification.Name = "c_ap_Classification";
            this.c_ap_Classification.ReadOnly = true;
            this.c_ap_Classification.Width = 93;
            // 
            // c_ap_Architecture
            // 
            this.c_ap_Architecture.HeaderText = "Architecture";
            this.c_ap_Architecture.Name = "c_ap_Architecture";
            this.c_ap_Architecture.ReadOnly = true;
            this.c_ap_Architecture.Width = 75;
            // 
            // c_ap_DateCreated
            // 
            this.c_ap_DateCreated.HeaderText = "Date Created";
            this.c_ap_DateCreated.Name = "c_ap_DateCreated";
            this.c_ap_DateCreated.ReadOnly = true;
            this.c_ap_DateCreated.Width = 95;
            // 
            // c_ap_dateReleased
            // 
            this.c_ap_dateReleased.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_ap_dateReleased.HeaderText = "Date Released \\ Revised";
            this.c_ap_dateReleased.Name = "c_ap_dateReleased";
            this.c_ap_dateReleased.ReadOnly = true;
            // 
            // dgv_ignorePatches
            // 
            this.dgv_ignorePatches.AllowUserToAddRows = false;
            this.dgv_ignorePatches.AllowUserToDeleteRows = false;
            this.dgv_ignorePatches.AllowUserToOrderColumns = true;
            this.dgv_ignorePatches.AllowUserToResizeRows = false;
            this.dgv_ignorePatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ignorePatches.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_ignorePatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ignorePatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_ignorepatches_KBID,
            this.c_ignorepatches_LocalizedDisplayName,
            this.c_ignorepatches_Product,
            this.c_ignorepatches_Classification});
            this.dgv_ignorePatches.ContextMenuStrip = this.cmt_Patch;
            this.dgv_ignorePatches.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_ignorePatches.Location = new System.Drawing.Point(3, 3);
            this.dgv_ignorePatches.Name = "dgv_ignorePatches";
            this.dgv_ignorePatches.ReadOnly = true;
            this.dgv_ignorePatches.RowHeadersVisible = false;
            this.dgv_ignorePatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ignorePatches.Size = new System.Drawing.Size(1063, 568);
            this.dgv_ignorePatches.TabIndex = 37;
            this.dgv_ignorePatches.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ignorePatches_CellContentDoubleClick);
            // 
            // c_ignorepatches_KBID
            // 
            this.c_ignorepatches_KBID.HeaderText = "Patch KB";
            this.c_ignorepatches_KBID.Name = "c_ignorepatches_KBID";
            this.c_ignorepatches_KBID.ReadOnly = true;
            this.c_ignorepatches_KBID.Width = 77;
            // 
            // c_ignorepatches_LocalizedDisplayName
            // 
            this.c_ignorepatches_LocalizedDisplayName.HeaderText = "Display Name";
            this.c_ignorepatches_LocalizedDisplayName.Name = "c_ignorepatches_LocalizedDisplayName";
            this.c_ignorepatches_LocalizedDisplayName.ReadOnly = true;
            this.c_ignorepatches_LocalizedDisplayName.Width = 77;
            // 
            // c_ignorepatches_Product
            // 
            this.c_ignorepatches_Product.HeaderText = "Product";
            this.c_ignorepatches_Product.Name = "c_ignorepatches_Product";
            this.c_ignorepatches_Product.ReadOnly = true;
            this.c_ignorepatches_Product.Width = 120;
            // 
            // c_ignorepatches_Classification
            // 
            this.c_ignorepatches_Classification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_ignorepatches_Classification.HeaderText = "Classification";
            this.c_ignorepatches_Classification.Name = "c_ignorepatches_Classification";
            this.c_ignorepatches_Classification.ReadOnly = true;
            // 
            // cmt_Patch
            // 
            this.cmt_Patch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ignorePatch});
            this.cmt_Patch.Name = "cmt_Patch";
            this.cmt_Patch.Size = new System.Drawing.Size(142, 26);
            // 
            // tsmi_ignorePatch
            // 
            this.tsmi_ignorePatch.Name = "tsmi_ignorePatch";
            this.tsmi_ignorePatch.Size = new System.Drawing.Size(141, 22);
            this.tsmi_ignorePatch.Text = "Ignore Patch";
            this.tsmi_ignorePatch.Click += new System.EventHandler(this.tsmi_ignorePatch_Click);
            // 
            // dgv_SecurityScopes
            // 
            this.dgv_SecurityScopes.AllowUserToDeleteRows = false;
            this.dgv_SecurityScopes.AllowUserToOrderColumns = true;
            this.dgv_SecurityScopes.AllowUserToResizeRows = false;
            this.dgv_SecurityScopes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SecurityScopes.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_SecurityScopes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SecurityScopes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_scoping_deviceType,
            this.c_scoping_Type,
            this.c_scoping_Scope});
            this.dgv_SecurityScopes.Location = new System.Drawing.Point(3, 3);
            this.dgv_SecurityScopes.Name = "dgv_SecurityScopes";
            this.dgv_SecurityScopes.Size = new System.Drawing.Size(1062, 533);
            this.dgv_SecurityScopes.TabIndex = 39;
            this.dgv_SecurityScopes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_SecurityScopes_DataError);
            this.dgv_SecurityScopes.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SecurityScopes_RowLeave);
            // 
            // c_scoping_deviceType
            // 
            this.c_scoping_deviceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_scoping_deviceType.HeaderText = "Device Group";
            this.c_scoping_deviceType.Items.AddRange(new object[] {
            "Client",
            "Server"});
            this.c_scoping_deviceType.Name = "c_scoping_deviceType";
            this.c_scoping_deviceType.Sorted = true;
            this.c_scoping_deviceType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_scoping_deviceType.Width = 98;
            // 
            // c_scoping_Type
            // 
            this.c_scoping_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_scoping_Type.HeaderText = "Scope Type";
            this.c_scoping_Type.Items.AddRange(new object[] {
            "Deployment",
            "Reporting"});
            this.c_scoping_Type.Name = "c_scoping_Type";
            this.c_scoping_Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_scoping_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_scoping_Type.Width = 90;
            // 
            // c_scoping_Scope
            // 
            this.c_scoping_Scope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_scoping_Scope.HeaderText = "Scope";
            this.c_scoping_Scope.Name = "c_scoping_Scope";
            this.c_scoping_Scope.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tc_Main
            // 
            this.tc_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_Main.Controls.Add(this.tb_Config);
            this.tc_Main.Controls.Add(this.tb_Rules);
            this.tc_Main.Controls.Add(this.tb_Deployments);
            this.tc_Main.Controls.Add(this.tb_SecurityScopes);
            this.tc_Main.Controls.Add(this.tb_AvailablePatches);
            this.tc_Main.Controls.Add(this.tb_IgnorePatches);
            this.tc_Main.Controls.Add(this.tb_SUMaint);
            this.tc_Main.Controls.Add(this.tb_WSUS);
            this.tc_Main.Controls.Add(this.tb_Log);
            this.tc_Main.Controls.Add(this.tb_About);
            this.tc_Main.Location = new System.Drawing.Point(-7, -1);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(1077, 602);
            this.tc_Main.TabIndex = 41;
            // 
            // tb_Config
            // 
            this.tb_Config.BackColor = System.Drawing.Color.Black;
            this.tb_Config.Controls.Add(this.groupBox9);
            this.tb_Config.Controls.Add(this.groupBox8);
            this.tb_Config.Controls.Add(this.gb_namingBar);
            this.tb_Config.Controls.Add(this.groupBox7);
            this.tb_Config.Controls.Add(this.groupBox6);
            this.tb_Config.Controls.Add(this.groupBox5);
            this.tb_Config.Controls.Add(this.groupBox4);
            this.tb_Config.Controls.Add(this.groupBox3);
            this.tb_Config.Controls.Add(this.groupBox2);
            this.tb_Config.Controls.Add(this.groupBox1);
            this.tb_Config.Location = new System.Drawing.Point(4, 22);
            this.tb_Config.Name = "tb_Config";
            this.tb_Config.Size = new System.Drawing.Size(1069, 576);
            this.tb_Config.TabIndex = 5;
            this.tb_Config.Text = "Configure";
            this.tb_Config.Click += new System.EventHandler(this.tb_Config_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.b_openLog);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox9.Location = new System.Drawing.Point(154, 505);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(60, 55);
            this.groupBox9.TabIndex = 67;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Log";
            // 
            // b_openLog
            // 
            this.b_openLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_openLog.Location = new System.Drawing.Point(6, 21);
            this.b_openLog.Name = "b_openLog";
            this.b_openLog.Size = new System.Drawing.Size(47, 23);
            this.b_openLog.TabIndex = 0;
            this.b_openLog.Text = "Open";
            this.b_openLog.UseVisualStyleBackColor = true;
            this.b_openLog.Click += new System.EventHandler(this.b_openLog_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.nud_downloadRetry);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox8.Location = new System.Drawing.Point(9, 506);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(139, 54);
            this.groupBox8.TabIndex = 66;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Download Settings";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Failure retry";
            // 
            // nud_downloadRetry
            // 
            this.nud_downloadRetry.Location = new System.Drawing.Point(73, 22);
            this.nud_downloadRetry.Name = "nud_downloadRetry";
            this.nud_downloadRetry.Size = new System.Drawing.Size(52, 20);
            this.nud_downloadRetry.TabIndex = 0;
            this.nud_downloadRetry.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nud_downloadRetry.ValueChanged += new System.EventHandler(this.nud_downloadRetry_ValueChanged);
            // 
            // gb_namingBar
            // 
            this.gb_namingBar.Controls.Add(this.label16);
            this.gb_namingBar.Controls.Add(this.flp_namingSelections);
            this.gb_namingBar.Controls.Add(this.tb_addTextbox);
            this.gb_namingBar.Controls.Add(this.b_addDay);
            this.gb_namingBar.Controls.Add(this.b_addMonth);
            this.gb_namingBar.Controls.Add(this.b_addYear);
            this.gb_namingBar.Controls.Add(this.b_addClassification);
            this.gb_namingBar.Controls.Add(this.b_addArchitecture);
            this.gb_namingBar.Controls.Add(this.cb_patchnamingDelimiter);
            this.gb_namingBar.Controls.Add(this.b_addReporting);
            this.gb_namingBar.Controls.Add(this.b_addOOC);
            this.gb_namingBar.Controls.Add(this.cb_unlocknamingBar);
            this.gb_namingBar.Controls.Add(this.b_addLanguage);
            this.gb_namingBar.Controls.Add(this.b_addProduct);
            this.gb_namingBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_namingBar.Location = new System.Drawing.Point(9, 3);
            this.gb_namingBar.Name = "gb_namingBar";
            this.gb_namingBar.Size = new System.Drawing.Size(1054, 88);
            this.gb_namingBar.TabIndex = 65;
            this.gb_namingBar.TabStop = false;
            this.gb_namingBar.Text = "Naming Bar";
            this.gb_namingBar.Enter += new System.EventHandler(this.gb_namingBar_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(836, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 65;
            this.label16.Text = "Delimiter";
            // 
            // flp_namingSelections
            // 
            this.flp_namingSelections.AllowDrop = true;
            this.flp_namingSelections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_namingSelections.AutoSize = true;
            this.flp_namingSelections.BackColor = System.Drawing.Color.LightGray;
            this.flp_namingSelections.Location = new System.Drawing.Point(6, 19);
            this.flp_namingSelections.Name = "flp_namingSelections";
            this.flp_namingSelections.Size = new System.Drawing.Size(1042, 26);
            this.flp_namingSelections.TabIndex = 45;
            this.flp_namingSelections.WrapContents = false;
            this.flp_namingSelections.DragDrop += new System.Windows.Forms.DragEventHandler(this.flp_namingSelections_DragDrop);
            this.flp_namingSelections.DragEnter += new System.Windows.Forms.DragEventHandler(this.flp_namingSelections_DragEnter);
            this.flp_namingSelections.DragLeave += new System.EventHandler(this.flp_namingSelections_DragLeave);
            this.flp_namingSelections.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_namingSelections_Paint);
            this.flp_namingSelections.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragdrop_MouseDown);
            // 
            // tb_addTextbox
            // 
            this.tb_addTextbox.Location = new System.Drawing.Point(6, 57);
            this.tb_addTextbox.Name = "tb_addTextbox";
            this.tb_addTextbox.Size = new System.Drawing.Size(93, 20);
            this.tb_addTextbox.TabIndex = 48;
            this.tb_addTextbox.TextChanged += new System.EventHandler(this.tb_addTextbox_TextChanged);
            this.tb_addTextbox.DoubleClick += new System.EventHandler(this.tb_addTextbox_DoubleClick);
            // 
            // b_addDay
            // 
            this.b_addDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_addDay.Location = new System.Drawing.Point(105, 55);
            this.b_addDay.Name = "b_addDay";
            this.b_addDay.Size = new System.Drawing.Size(93, 23);
            this.b_addDay.TabIndex = 49;
            this.b_addDay.Text = "Day";
            this.b_addDay.UseVisualStyleBackColor = true;
            this.b_addDay.Click += new System.EventHandler(this.b_addDay_Click);
            // 
            // b_addMonth
            // 
            this.b_addMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_addMonth.Location = new System.Drawing.Point(203, 55);
            this.b_addMonth.Name = "b_addMonth";
            this.b_addMonth.Size = new System.Drawing.Size(93, 23);
            this.b_addMonth.TabIndex = 50;
            this.b_addMonth.Text = "Month";
            this.b_addMonth.UseVisualStyleBackColor = true;
            this.b_addMonth.Click += new System.EventHandler(this.b_addMonth_Click);
            // 
            // b_addYear
            // 
            this.b_addYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_addYear.Location = new System.Drawing.Point(302, 55);
            this.b_addYear.Name = "b_addYear";
            this.b_addYear.Size = new System.Drawing.Size(93, 23);
            this.b_addYear.TabIndex = 51;
            this.b_addYear.Text = "Year";
            this.b_addYear.UseVisualStyleBackColor = true;
            this.b_addYear.Click += new System.EventHandler(this.b_addYear_Click);
            // 
            // b_addClassification
            // 
            this.b_addClassification.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_addClassification.Location = new System.Drawing.Point(401, 55);
            this.b_addClassification.Name = "b_addClassification";
            this.b_addClassification.Size = new System.Drawing.Size(93, 23);
            this.b_addClassification.TabIndex = 52;
            this.b_addClassification.Text = "Classification";
            this.b_addClassification.UseVisualStyleBackColor = true;
            this.b_addClassification.Click += new System.EventHandler(this.b_addClassification_Click);
            // 
            // b_addArchitecture
            // 
            this.b_addArchitecture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_addArchitecture.Location = new System.Drawing.Point(500, 55);
            this.b_addArchitecture.Name = "b_addArchitecture";
            this.b_addArchitecture.Size = new System.Drawing.Size(93, 23);
            this.b_addArchitecture.TabIndex = 54;
            this.b_addArchitecture.Text = "Architecture";
            this.b_addArchitecture.UseVisualStyleBackColor = true;
            this.b_addArchitecture.Click += new System.EventHandler(this.b_addArchitecture_Click);
            // 
            // cb_patchnamingDelimiter
            // 
            this.cb_patchnamingDelimiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_patchnamingDelimiter.FormattingEnabled = true;
            this.cb_patchnamingDelimiter.Items.AddRange(new object[] {
            " - ",
            " -- ",
            "-",
            "--",
            " # ",
            "#",
            " : ",
            ":",
            " | ",
            "|",
            " "});
            this.cb_patchnamingDelimiter.Location = new System.Drawing.Point(889, 56);
            this.cb_patchnamingDelimiter.Name = "cb_patchnamingDelimiter";
            this.cb_patchnamingDelimiter.Size = new System.Drawing.Size(93, 21);
            this.cb_patchnamingDelimiter.TabIndex = 56;
            this.cb_patchnamingDelimiter.SelectedIndexChanged += new System.EventHandler(this.cb_patchnamingDelimiter_SelectedIndexChanged);
            this.cb_patchnamingDelimiter.TextChanged += new System.EventHandler(this.cb_patchnamingDelimiter_TextChanged);
            // 
            // b_addReporting
            // 
            this.b_addReporting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_addReporting.Location = new System.Drawing.Point(703, 55);
            this.b_addReporting.Name = "b_addReporting";
            this.b_addReporting.Size = new System.Drawing.Size(93, 23);
            this.b_addReporting.TabIndex = 64;
            this.b_addReporting.Text = "Reporting";
            this.b_addReporting.UseVisualStyleBackColor = true;
            this.b_addReporting.Visible = false;
            this.b_addReporting.Click += new System.EventHandler(this.b_addReporting_Click);
            // 
            // b_addOOC
            // 
            this.b_addOOC.Location = new System.Drawing.Point(703, 55);
            this.b_addOOC.Name = "b_addOOC";
            this.b_addOOC.Size = new System.Drawing.Size(93, 23);
            this.b_addOOC.TabIndex = 55;
            this.b_addOOC.Text = "Out of Cycle";
            this.b_addOOC.UseVisualStyleBackColor = true;
            this.b_addOOC.Visible = false;
            this.b_addOOC.Click += new System.EventHandler(this.b_OOC_Click);
            // 
            // cb_unlocknamingBar
            // 
            this.cb_unlocknamingBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_unlocknamingBar.AutoSize = true;
            this.cb_unlocknamingBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_unlocknamingBar.Location = new System.Drawing.Point(988, 58);
            this.cb_unlocknamingBar.Name = "cb_unlocknamingBar";
            this.cb_unlocknamingBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_unlocknamingBar.Size = new System.Drawing.Size(60, 17);
            this.cb_unlocknamingBar.TabIndex = 59;
            this.cb_unlocknamingBar.Text = "Unlock";
            this.cb_unlocknamingBar.UseVisualStyleBackColor = true;
            this.cb_unlocknamingBar.CheckedChanged += new System.EventHandler(this.cb_unlocknamingBar_CheckedChanged);
            // 
            // b_addLanguage
            // 
            this.b_addLanguage.Location = new System.Drawing.Point(703, 55);
            this.b_addLanguage.Name = "b_addLanguage";
            this.b_addLanguage.Size = new System.Drawing.Size(93, 23);
            this.b_addLanguage.TabIndex = 53;
            this.b_addLanguage.Text = "Language";
            this.b_addLanguage.UseVisualStyleBackColor = true;
            this.b_addLanguage.Visible = false;
            this.b_addLanguage.Click += new System.EventHandler(this.b_addLanguage_Click);
            // 
            // b_addProduct
            // 
            this.b_addProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_addProduct.Location = new System.Drawing.Point(599, 55);
            this.b_addProduct.Name = "b_addProduct";
            this.b_addProduct.Size = new System.Drawing.Size(93, 23);
            this.b_addProduct.TabIndex = 47;
            this.b_addProduct.Text = "Product";
            this.b_addProduct.UseVisualStyleBackColor = true;
            this.b_addProduct.Click += new System.EventHandler(this.b_addProduct_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cb_rollupOffice);
            this.groupBox7.Controls.Add(this.cb_rollupserverOS);
            this.groupBox7.Controls.Add(this.cb_rollupclientOS);
            this.groupBox7.Controls.Add(this.cb_createreportingSUGS);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Location = new System.Drawing.Point(220, 506);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(435, 54);
            this.groupBox7.TabIndex = 63;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Reporting";
            // 
            // cb_rollupOffice
            // 
            this.cb_rollupOffice.AutoSize = true;
            this.cb_rollupOffice.Checked = true;
            this.cb_rollupOffice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_rollupOffice.Location = new System.Drawing.Point(319, 23);
            this.cb_rollupOffice.Name = "cb_rollupOffice";
            this.cb_rollupOffice.Size = new System.Drawing.Size(87, 17);
            this.cb_rollupOffice.TabIndex = 3;
            this.cb_rollupOffice.Text = "Rollup Office";
            this.cb_rollupOffice.UseVisualStyleBackColor = true;
            this.cb_rollupOffice.CheckedChanged += new System.EventHandler(this.cb_rollupOffice_CheckedChanged);
            // 
            // cb_rollupserverOS
            // 
            this.cb_rollupserverOS.AutoSize = true;
            this.cb_rollupserverOS.Checked = true;
            this.cb_rollupserverOS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_rollupserverOS.Location = new System.Drawing.Point(223, 23);
            this.cb_rollupserverOS.Name = "cb_rollupserverOS";
            this.cb_rollupserverOS.Size = new System.Drawing.Size(90, 17);
            this.cb_rollupserverOS.TabIndex = 2;
            this.cb_rollupserverOS.Text = "Rollup Server";
            this.cb_rollupserverOS.UseVisualStyleBackColor = true;
            this.cb_rollupserverOS.CheckedChanged += new System.EventHandler(this.cb_rollupserverOS_CheckedChanged);
            // 
            // cb_rollupclientOS
            // 
            this.cb_rollupclientOS.AutoSize = true;
            this.cb_rollupclientOS.Checked = true;
            this.cb_rollupclientOS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_rollupclientOS.Location = new System.Drawing.Point(132, 23);
            this.cb_rollupclientOS.Name = "cb_rollupclientOS";
            this.cb_rollupclientOS.Size = new System.Drawing.Size(85, 17);
            this.cb_rollupclientOS.TabIndex = 1;
            this.cb_rollupclientOS.Text = "Rollup Client";
            this.cb_rollupclientOS.UseVisualStyleBackColor = true;
            this.cb_rollupclientOS.CheckedChanged += new System.EventHandler(this.cb_rollupclientOS_CheckedChanged);
            // 
            // cb_createreportingSUGS
            // 
            this.cb_createreportingSUGS.AutoSize = true;
            this.cb_createreportingSUGS.Checked = true;
            this.cb_createreportingSUGS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_createreportingSUGS.Location = new System.Drawing.Point(6, 23);
            this.cb_createreportingSUGS.Name = "cb_createreportingSUGS";
            this.cb_createreportingSUGS.Size = new System.Drawing.Size(120, 17);
            this.cb_createreportingSUGS.TabIndex = 0;
            this.cb_createreportingSUGS.Text = "Rollup Classification";
            this.cb_createreportingSUGS.UseVisualStyleBackColor = true;
            this.cb_createreportingSUGS.CheckedChanged += new System.EventHandler(this.cb_createreportingSUGS_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cb_deployment_RandomizationEnabled);
            this.groupBox6.Controls.Add(this.b_Debug);
            this.groupBox6.Controls.Add(this.cb_deployment_overrideserviceWindows);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.cb_deployment_statemessagePriority);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.cb_deployment_statemessageVerbosity);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.cb_deploymentdeviceGroup);
            this.groupBox6.Controls.Add(this.cb_deployment_useruiExperience);
            this.groupBox6.Controls.Add(this.cb_deployment_raisemomalertsonFailure);
            this.groupBox6.Controls.Add(this.cb_deployment_useutcTimes);
            this.groupBox6.Controls.Add(this.cb_deployment_senddetailednonCompliance);
            this.groupBox6.Controls.Add(this.cb_deployment_notifyUser);
            this.groupBox6.Controls.Add(this.cb_deployment_logtowinEvent);
            this.groupBox6.Controls.Add(this.cb_deployment_limitstatemsgverbosity);
            this.groupBox6.Controls.Add(this.cb_deployment_disablemomAlerts);
            this.groupBox6.Controls.Add(this.cb_deployment_useBranchcache);
            this.groupBox6.Controls.Add(this.cb_deployment_enableWOL);
            this.groupBox6.Controls.Add(this.cb_deployment_allowMetered);
            this.groupBox6.Controls.Add(this.cb_deployment_usemsUpdates);
            this.groupBox6.Controls.Add(this.cb_deployment_defaultFallback);
            this.groupBox6.Controls.Add(this.cb_deployment_downloadNeighbour);
            this.groupBox6.Controls.Add(this.cb_deployment_Evaluation);
            this.groupBox6.Controls.Add(this.cb_deployment_commitFilter);
            this.groupBox6.Controls.Add(this.cb_deployment_supressWorkstations);
            this.groupBox6.Controls.Add(this.cb_deployment_supressServers);
            this.groupBox6.Controls.Add(this.cb_deployment_deadlinerestart);
            this.groupBox6.Controls.Add(this.cb_deployment_delayEnforcement);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Location = new System.Drawing.Point(661, 97);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(402, 463);
            this.groupBox6.TabIndex = 62;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Deployment Settings";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // cb_deployment_RandomizationEnabled
            // 
            this.cb_deployment_RandomizationEnabled.AutoSize = true;
            this.cb_deployment_RandomizationEnabled.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_RandomizationEnabled.Location = new System.Drawing.Point(177, 303);
            this.cb_deployment_RandomizationEnabled.Name = "cb_deployment_RandomizationEnabled";
            this.cb_deployment_RandomizationEnabled.Size = new System.Drawing.Size(138, 17);
            this.cb_deployment_RandomizationEnabled.TabIndex = 36;
            this.cb_deployment_RandomizationEnabled.Text = "Randomization Enabled";
            this.cb_deployment_RandomizationEnabled.UseVisualStyleBackColor = true;
            this.cb_deployment_RandomizationEnabled.CheckedChanged += new System.EventHandler(this.cb_deployment_RandomizationEnabled_CheckedChanged);
            // 
            // b_Debug
            // 
            this.b_Debug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Debug.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_Debug.Location = new System.Drawing.Point(314, 421);
            this.b_Debug.Name = "b_Debug";
            this.b_Debug.Size = new System.Drawing.Size(75, 23);
            this.b_Debug.TabIndex = 35;
            this.b_Debug.Text = "Debug";
            this.b_Debug.UseVisualStyleBackColor = true;
            this.b_Debug.Visible = false;
            this.b_Debug.Click += new System.EventHandler(this.b_Debug_Click);
            // 
            // cb_deployment_overrideserviceWindows
            // 
            this.cb_deployment_overrideserviceWindows.AutoSize = true;
            this.cb_deployment_overrideserviceWindows.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_overrideserviceWindows.Location = new System.Drawing.Point(6, 118);
            this.cb_deployment_overrideserviceWindows.Name = "cb_deployment_overrideserviceWindows";
            this.cb_deployment_overrideserviceWindows.Size = new System.Drawing.Size(144, 17);
            this.cb_deployment_overrideserviceWindows.TabIndex = 33;
            this.cb_deployment_overrideserviceWindows.Text = "Deadline - SU installation";
            this.cb_deployment_overrideserviceWindows.UseVisualStyleBackColor = true;
            this.cb_deployment_overrideserviceWindows.CheckedChanged += new System.EventHandler(this.cb_overrideserviceWindows_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(302, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "State msg priority";
            // 
            // cb_deployment_statemessagePriority
            // 
            this.cb_deployment_statemessagePriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_deployment_statemessagePriority.FormattingEnabled = true;
            this.cb_deployment_statemessagePriority.Items.AddRange(new object[] {
            "High",
            "Low",
            "Normal",
            "Urgent"});
            this.cb_deployment_statemessagePriority.Location = new System.Drawing.Point(177, 207);
            this.cb_deployment_statemessagePriority.Name = "cb_deployment_statemessagePriority";
            this.cb_deployment_statemessagePriority.Size = new System.Drawing.Size(121, 21);
            this.cb_deployment_statemessagePriority.Sorted = true;
            this.cb_deployment_statemessagePriority.TabIndex = 31;
            this.cb_deployment_statemessagePriority.SelectedIndexChanged += new System.EventHandler(this.cb_deployment_statemessagePriority_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(304, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "State Msg Detail";
            // 
            // cb_deployment_statemessageVerbosity
            // 
            this.cb_deployment_statemessageVerbosity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_deployment_statemessageVerbosity.FormattingEnabled = true;
            this.cb_deployment_statemessageVerbosity.Items.AddRange(new object[] {
            "All",
            "Errors",
            "Successes and Errors"});
            this.cb_deployment_statemessageVerbosity.Location = new System.Drawing.Point(177, 232);
            this.cb_deployment_statemessageVerbosity.Name = "cb_deployment_statemessageVerbosity";
            this.cb_deployment_statemessageVerbosity.Size = new System.Drawing.Size(121, 21);
            this.cb_deployment_statemessageVerbosity.Sorted = true;
            this.cb_deployment_statemessageVerbosity.TabIndex = 29;
            this.cb_deployment_statemessageVerbosity.SelectedIndexChanged += new System.EventHandler(this.cb_deployment_statemessageVerbosity_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Device Group";
            // 
            // cb_deploymentdeviceGroup
            // 
            this.cb_deploymentdeviceGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_deploymentdeviceGroup.FormattingEnabled = true;
            this.cb_deploymentdeviceGroup.Location = new System.Drawing.Point(85, 25);
            this.cb_deploymentdeviceGroup.Name = "cb_deploymentdeviceGroup";
            this.cb_deploymentdeviceGroup.Size = new System.Drawing.Size(193, 21);
            this.cb_deploymentdeviceGroup.Sorted = true;
            this.cb_deploymentdeviceGroup.TabIndex = 27;
            this.cb_deploymentdeviceGroup.SelectedIndexChanged += new System.EventHandler(this.cb_deploymentdeviceGroup_SelectedIndexChanged);
            this.cb_deploymentdeviceGroup.SelectedValueChanged += new System.EventHandler(this.cb_deploymentdeviceGroup_SelectedValueChanged);
            // 
            // cb_deployment_useruiExperience
            // 
            this.cb_deployment_useruiExperience.AutoSize = true;
            this.cb_deployment_useruiExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_useruiExperience.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_useruiExperience.Location = new System.Drawing.Point(177, 279);
            this.cb_deployment_useruiExperience.Name = "cb_deployment_useruiExperience";
            this.cb_deployment_useruiExperience.Size = new System.Drawing.Size(118, 17);
            this.cb_deployment_useruiExperience.TabIndex = 26;
            this.cb_deployment_useruiExperience.Text = "User UI Experience";
            this.cb_deployment_useruiExperience.UseVisualStyleBackColor = true;
            this.cb_deployment_useruiExperience.CheckedChanged += new System.EventHandler(this.cb_deployment_useruiExperience_CheckedChanged);
            // 
            // cb_deployment_raisemomalertsonFailure
            // 
            this.cb_deployment_raisemomalertsonFailure.AutoSize = true;
            this.cb_deployment_raisemomalertsonFailure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_raisemomalertsonFailure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_raisemomalertsonFailure.Location = new System.Drawing.Point(177, 165);
            this.cb_deployment_raisemomalertsonFailure.Name = "cb_deployment_raisemomalertsonFailure";
            this.cb_deployment_raisemomalertsonFailure.Size = new System.Drawing.Size(154, 17);
            this.cb_deployment_raisemomalertsonFailure.TabIndex = 24;
            this.cb_deployment_raisemomalertsonFailure.Text = "Raise Mom Alerts on failure";
            this.cb_deployment_raisemomalertsonFailure.UseVisualStyleBackColor = true;
            this.cb_deployment_raisemomalertsonFailure.CheckedChanged += new System.EventHandler(this.cb_deployment_raisemomalertsonFailure_CheckedChanged);
            // 
            // cb_deployment_useutcTimes
            // 
            this.cb_deployment_useutcTimes.AutoSize = true;
            this.cb_deployment_useutcTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_useutcTimes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_useutcTimes.Location = new System.Drawing.Point(177, 259);
            this.cb_deployment_useutcTimes.Name = "cb_deployment_useutcTimes";
            this.cb_deployment_useutcTimes.Size = new System.Drawing.Size(101, 17);
            this.cb_deployment_useutcTimes.TabIndex = 23;
            this.cb_deployment_useutcTimes.Text = "Use UTC Times";
            this.cb_deployment_useutcTimes.UseVisualStyleBackColor = true;
            this.cb_deployment_useutcTimes.CheckedChanged += new System.EventHandler(this.cb_deployment_useutcTimes_CheckedChanged);
            // 
            // cb_deployment_senddetailednonCompliance
            // 
            this.cb_deployment_senddetailednonCompliance.AutoSize = true;
            this.cb_deployment_senddetailednonCompliance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_senddetailednonCompliance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_senddetailednonCompliance.Location = new System.Drawing.Point(177, 188);
            this.cb_deployment_senddetailednonCompliance.Name = "cb_deployment_senddetailednonCompliance";
            this.cb_deployment_senddetailednonCompliance.Size = new System.Drawing.Size(169, 17);
            this.cb_deployment_senddetailednonCompliance.TabIndex = 20;
            this.cb_deployment_senddetailednonCompliance.Text = "Send detailed non-compliance";
            this.cb_deployment_senddetailednonCompliance.UseVisualStyleBackColor = true;
            this.cb_deployment_senddetailednonCompliance.CheckedChanged += new System.EventHandler(this.cb_deployment_senddetailednonCompliance_CheckedChanged);
            // 
            // cb_deployment_notifyUser
            // 
            this.cb_deployment_notifyUser.AutoSize = true;
            this.cb_deployment_notifyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_notifyUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_notifyUser.Location = new System.Drawing.Point(177, 141);
            this.cb_deployment_notifyUser.Name = "cb_deployment_notifyUser";
            this.cb_deployment_notifyUser.Size = new System.Drawing.Size(78, 17);
            this.cb_deployment_notifyUser.TabIndex = 17;
            this.cb_deployment_notifyUser.Text = "Notify User";
            this.cb_deployment_notifyUser.UseVisualStyleBackColor = true;
            this.cb_deployment_notifyUser.CheckedChanged += new System.EventHandler(this.cb_deployment_notifyUser_CheckedChanged);
            // 
            // cb_deployment_logtowinEvent
            // 
            this.cb_deployment_logtowinEvent.AutoSize = true;
            this.cb_deployment_logtowinEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_logtowinEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_logtowinEvent.Location = new System.Drawing.Point(177, 118);
            this.cb_deployment_logtowinEvent.Name = "cb_deployment_logtowinEvent";
            this.cb_deployment_logtowinEvent.Size = new System.Drawing.Size(127, 17);
            this.cb_deployment_logtowinEvent.TabIndex = 16;
            this.cb_deployment_logtowinEvent.Text = "Log Windows Events";
            this.cb_deployment_logtowinEvent.UseVisualStyleBackColor = true;
            this.cb_deployment_logtowinEvent.CheckedChanged += new System.EventHandler(this.cb_deployment_logtowinEvent_CheckedChanged);
            // 
            // cb_deployment_limitstatemsgverbosity
            // 
            this.cb_deployment_limitstatemsgverbosity.AutoSize = true;
            this.cb_deployment_limitstatemsgverbosity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_limitstatemsgverbosity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_limitstatemsgverbosity.Location = new System.Drawing.Point(177, 95);
            this.cb_deployment_limitstatemsgverbosity.Name = "cb_deployment_limitstatemsgverbosity";
            this.cb_deployment_limitstatemsgverbosity.Size = new System.Drawing.Size(163, 17);
            this.cb_deployment_limitstatemsgverbosity.TabIndex = 15;
            this.cb_deployment_limitstatemsgverbosity.Text = "Limit state message verbosity";
            this.cb_deployment_limitstatemsgverbosity.UseVisualStyleBackColor = true;
            this.cb_deployment_limitstatemsgverbosity.CheckedChanged += new System.EventHandler(this.cb_deployment_limitstatemsgverbosity_CheckedChanged);
            // 
            // cb_deployment_disablemomAlerts
            // 
            this.cb_deployment_disablemomAlerts.AutoSize = true;
            this.cb_deployment_disablemomAlerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_disablemomAlerts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_disablemomAlerts.Location = new System.Drawing.Point(177, 72);
            this.cb_deployment_disablemomAlerts.Name = "cb_deployment_disablemomAlerts";
            this.cb_deployment_disablemomAlerts.Size = new System.Drawing.Size(116, 17);
            this.cb_deployment_disablemomAlerts.TabIndex = 13;
            this.cb_deployment_disablemomAlerts.Text = "Disable Mom Alerts";
            this.cb_deployment_disablemomAlerts.UseVisualStyleBackColor = true;
            this.cb_deployment_disablemomAlerts.CheckedChanged += new System.EventHandler(this.cb_deployment_disablemomAlerts_CheckedChanged);
            // 
            // cb_deployment_useBranchcache
            // 
            this.cb_deployment_useBranchcache.AutoSize = true;
            this.cb_deployment_useBranchcache.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_useBranchcache.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_useBranchcache.Location = new System.Drawing.Point(7, 351);
            this.cb_deployment_useBranchcache.Name = "cb_deployment_useBranchcache";
            this.cb_deployment_useBranchcache.Size = new System.Drawing.Size(113, 17);
            this.cb_deployment_useBranchcache.TabIndex = 12;
            this.cb_deployment_useBranchcache.Text = "Use BranchCache";
            this.cb_deployment_useBranchcache.UseVisualStyleBackColor = true;
            this.cb_deployment_useBranchcache.CheckedChanged += new System.EventHandler(this.cb_deployment_useBranchcache_CheckedChanged);
            // 
            // cb_deployment_enableWOL
            // 
            this.cb_deployment_enableWOL.AutoSize = true;
            this.cb_deployment_enableWOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_enableWOL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_enableWOL.Location = new System.Drawing.Point(6, 71);
            this.cb_deployment_enableWOL.Name = "cb_deployment_enableWOL";
            this.cb_deployment_enableWOL.Size = new System.Drawing.Size(87, 17);
            this.cb_deployment_enableWOL.TabIndex = 11;
            this.cb_deployment_enableWOL.Text = "Enable WOL";
            this.cb_deployment_enableWOL.UseVisualStyleBackColor = true;
            this.cb_deployment_enableWOL.CheckedChanged += new System.EventHandler(this.cb_deployment_enableWOL_CheckedChanged);
            // 
            // cb_deployment_allowMetered
            // 
            this.cb_deployment_allowMetered.AutoSize = true;
            this.cb_deployment_allowMetered.Enabled = false;
            this.cb_deployment_allowMetered.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_allowMetered.Location = new System.Drawing.Point(7, 327);
            this.cb_deployment_allowMetered.Name = "cb_deployment_allowMetered";
            this.cb_deployment_allowMetered.Size = new System.Drawing.Size(130, 17);
            this.cb_deployment_allowMetered.TabIndex = 10;
            this.cb_deployment_allowMetered.Text = "Allow metered internet";
            this.cb_deployment_allowMetered.UseVisualStyleBackColor = true;
            this.cb_deployment_allowMetered.CheckedChanged += new System.EventHandler(this.cb_deployment_allowMetered_CheckedChanged);
            // 
            // cb_deployment_usemsUpdates
            // 
            this.cb_deployment_usemsUpdates.AutoSize = true;
            this.cb_deployment_usemsUpdates.Enabled = false;
            this.cb_deployment_usemsUpdates.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_usemsUpdates.Location = new System.Drawing.Point(7, 303);
            this.cb_deployment_usemsUpdates.Name = "cb_deployment_usemsUpdates";
            this.cb_deployment_usemsUpdates.Size = new System.Drawing.Size(101, 17);
            this.cb_deployment_usemsUpdates.TabIndex = 9;
            this.cb_deployment_usemsUpdates.Text = "Fall back to MU";
            this.cb_deployment_usemsUpdates.UseVisualStyleBackColor = true;
            this.cb_deployment_usemsUpdates.CheckedChanged += new System.EventHandler(this.cb_deployment_usemsUpdates_CheckedChanged);
            // 
            // cb_deployment_defaultFallback
            // 
            this.cb_deployment_defaultFallback.AutoSize = true;
            this.cb_deployment_defaultFallback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_defaultFallback.Location = new System.Drawing.Point(7, 279);
            this.cb_deployment_defaultFallback.Name = "cb_deployment_defaultFallback";
            this.cb_deployment_defaultFallback.Size = new System.Drawing.Size(157, 17);
            this.cb_deployment_defaultFallback.TabIndex = 8;
            this.cb_deployment_defaultFallback.Text = "Download - Default fallback";
            this.cb_deployment_defaultFallback.UseVisualStyleBackColor = true;
            this.cb_deployment_defaultFallback.CheckedChanged += new System.EventHandler(this.cb_deployment_defaultFallback_CheckedChanged);
            // 
            // cb_deployment_downloadNeighbour
            // 
            this.cb_deployment_downloadNeighbour.AutoSize = true;
            this.cb_deployment_downloadNeighbour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_downloadNeighbour.Location = new System.Drawing.Point(7, 256);
            this.cb_deployment_downloadNeighbour.Name = "cb_deployment_downloadNeighbour";
            this.cb_deployment_downloadNeighbour.Size = new System.Drawing.Size(172, 17);
            this.cb_deployment_downloadNeighbour.TabIndex = 7;
            this.cb_deployment_downloadNeighbour.Text = "Download - Neighbour fallback";
            this.cb_deployment_downloadNeighbour.UseVisualStyleBackColor = true;
            this.cb_deployment_downloadNeighbour.CheckedChanged += new System.EventHandler(this.cb_deployment_dowloadNeighbour_CheckedChanged);
            // 
            // cb_deployment_Evaluation
            // 
            this.cb_deployment_Evaluation.AutoSize = true;
            this.cb_deployment_Evaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_Evaluation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_Evaluation.Location = new System.Drawing.Point(6, 234);
            this.cb_deployment_Evaluation.Name = "cb_deployment_Evaluation";
            this.cb_deployment_Evaluation.Size = new System.Drawing.Size(137, 17);
            this.cb_deployment_Evaluation.TabIndex = 6;
            this.cb_deployment_Evaluation.Text = "Evaluation Cycle restart";
            this.cb_deployment_Evaluation.UseVisualStyleBackColor = true;
            this.cb_deployment_Evaluation.CheckedChanged += new System.EventHandler(this.cb_deployment_Evaluation_CheckedChanged);
            // 
            // cb_deployment_commitFilter
            // 
            this.cb_deployment_commitFilter.AutoSize = true;
            this.cb_deployment_commitFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_commitFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_commitFilter.Location = new System.Drawing.Point(6, 211);
            this.cb_deployment_commitFilter.Name = "cb_deployment_commitFilter";
            this.cb_deployment_commitFilter.Size = new System.Drawing.Size(116, 17);
            this.cb_deployment_commitFilter.TabIndex = 5;
            this.cb_deployment_commitFilter.Text = "Write filter - Commit";
            this.cb_deployment_commitFilter.UseVisualStyleBackColor = true;
            this.cb_deployment_commitFilter.CheckedChanged += new System.EventHandler(this.cb_deployment_commitFilter_CheckedChanged);
            // 
            // cb_deployment_supressWorkstations
            // 
            this.cb_deployment_supressWorkstations.AutoSize = true;
            this.cb_deployment_supressWorkstations.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_supressWorkstations.Location = new System.Drawing.Point(6, 187);
            this.cb_deployment_supressWorkstations.Name = "cb_deployment_supressWorkstations";
            this.cb_deployment_supressWorkstations.Size = new System.Drawing.Size(173, 17);
            this.cb_deployment_supressWorkstations.TabIndex = 4;
            this.cb_deployment_supressWorkstations.Text = "Supress Reboot - Workstations";
            this.cb_deployment_supressWorkstations.UseVisualStyleBackColor = true;
            this.cb_deployment_supressWorkstations.CheckedChanged += new System.EventHandler(this.cb_deployment_supressWorkstations_CheckedChanged);
            // 
            // cb_deployment_supressServers
            // 
            this.cb_deployment_supressServers.AutoSize = true;
            this.cb_deployment_supressServers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_supressServers.Location = new System.Drawing.Point(6, 165);
            this.cb_deployment_supressServers.Name = "cb_deployment_supressServers";
            this.cb_deployment_supressServers.Size = new System.Drawing.Size(147, 17);
            this.cb_deployment_supressServers.TabIndex = 3;
            this.cb_deployment_supressServers.Text = "Supress Reboot - Servers";
            this.cb_deployment_supressServers.UseVisualStyleBackColor = true;
            this.cb_deployment_supressServers.CheckedChanged += new System.EventHandler(this.cb_deployment_suppressServers_CheckedChanged);
            // 
            // cb_deployment_deadlinerestart
            // 
            this.cb_deployment_deadlinerestart.AutoSize = true;
            this.cb_deployment_deadlinerestart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_deadlinerestart.Location = new System.Drawing.Point(6, 141);
            this.cb_deployment_deadlinerestart.Name = "cb_deployment_deadlinerestart";
            this.cb_deployment_deadlinerestart.Size = new System.Drawing.Size(148, 17);
            this.cb_deployment_deadlinerestart.TabIndex = 2;
            this.cb_deployment_deadlinerestart.Text = "Deadline - System Restart";
            this.cb_deployment_deadlinerestart.UseVisualStyleBackColor = true;
            this.cb_deployment_deadlinerestart.CheckedChanged += new System.EventHandler(this.cb_deployment_deadlinerestart_CheckedChanged);
            // 
            // cb_deployment_delayEnforcement
            // 
            this.cb_deployment_delayEnforcement.AutoSize = true;
            this.cb_deployment_delayEnforcement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_deployment_delayEnforcement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_deployment_delayEnforcement.Location = new System.Drawing.Point(6, 94);
            this.cb_deployment_delayEnforcement.Name = "cb_deployment_delayEnforcement";
            this.cb_deployment_delayEnforcement.Size = new System.Drawing.Size(116, 17);
            this.cb_deployment_delayEnforcement.TabIndex = 0;
            this.cb_deployment_delayEnforcement.Text = "Delay Enforcement";
            this.cb_deployment_delayEnforcement.UseVisualStyleBackColor = true;
            this.cb_deployment_delayEnforcement.CheckedChanged += new System.EventHandler(this.cb_deployment_delayEnforcement_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_ooc_Tag);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(9, 452);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(166, 54);
            this.groupBox5.TabIndex = 61;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Out of Cycle Patch SUG Suffix";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_packageFolder);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tb_packagesourcePath);
            this.groupBox4.Controls.Add(this.b_createPath);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(9, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(646, 61);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Software Update Package Location";
            // 
            // b_createPath
            // 
            this.b_createPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_createPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_createPath.Location = new System.Drawing.Point(556, 29);
            this.b_createPath.Name = "b_createPath";
            this.b_createPath.Size = new System.Drawing.Size(75, 23);
            this.b_createPath.TabIndex = 38;
            this.b_createPath.Text = "Open Folder";
            this.b_createPath.UseVisualStyleBackColor = true;
            this.b_createPath.Click += new System.EventHandler(this.b_createPath_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pb_Tom);
            this.groupBox3.Controls.Add(this.cb_timemachine_Day);
            this.groupBox3.Controls.Add(this.cb_timeMachine);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cb_timemachine_Month);
            this.groupBox3.Controls.Add(this.cb_timemachine_Year);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(181, 452);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 54);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Machine";
            // 
            // pb_Tom
            // 
            this.pb_Tom.Location = new System.Drawing.Point(408, 8);
            this.pb_Tom.Name = "pb_Tom";
            this.pb_Tom.Size = new System.Drawing.Size(66, 42);
            this.pb_Tom.TabIndex = 58;
            this.pb_Tom.TabStop = false;
            // 
            // cb_timemachine_Day
            // 
            this.cb_timemachine_Day.FormattingEnabled = true;
            this.cb_timemachine_Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cb_timemachine_Day.Location = new System.Drawing.Point(51, 23);
            this.cb_timemachine_Day.Name = "cb_timemachine_Day";
            this.cb_timemachine_Day.Size = new System.Drawing.Size(52, 21);
            this.cb_timemachine_Day.TabIndex = 55;
            this.cb_timemachine_Day.SelectedIndexChanged += new System.EventHandler(this.cb_timemachine_Day_SelectedIndexChanged);
            // 
            // cb_timeMachine
            // 
            this.cb_timeMachine.AutoSize = true;
            this.cb_timeMachine.Location = new System.Drawing.Point(328, 25);
            this.cb_timeMachine.Name = "cb_timeMachine";
            this.cb_timeMachine.Size = new System.Drawing.Size(71, 17);
            this.cb_timeMachine.TabIndex = 57;
            this.cb_timeMachine.Text = "Activated";
            this.cb_timeMachine.UseVisualStyleBackColor = true;
            this.cb_timeMachine.CheckedChanged += new System.EventHandler(this.cb_timeMachine_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(25, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Day";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(109, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Month";
            // 
            // cb_timemachine_Month
            // 
            this.cb_timemachine_Month.FormattingEnabled = true;
            this.cb_timemachine_Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cb_timemachine_Month.Location = new System.Drawing.Point(146, 22);
            this.cb_timemachine_Month.Name = "cb_timemachine_Month";
            this.cb_timemachine_Month.Size = new System.Drawing.Size(64, 21);
            this.cb_timemachine_Month.TabIndex = 52;
            this.cb_timemachine_Month.SelectedIndexChanged += new System.EventHandler(this.cb_timemachine_Month_SelectedIndexChanged);
            // 
            // cb_timemachine_Year
            // 
            this.cb_timemachine_Year.FormattingEnabled = true;
            this.cb_timemachine_Year.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cb_timemachine_Year.Location = new System.Drawing.Point(247, 22);
            this.cb_timemachine_Year.Name = "cb_timemachine_Year";
            this.cb_timemachine_Year.Size = new System.Drawing.Size(60, 21);
            this.cb_timemachine_Year.TabIndex = 53;
            this.cb_timemachine_Year.SelectedIndexChanged += new System.EventHandler(this.cb_timemachine_Year_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(216, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Year";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_removeDP);
            this.groupBox2.Controls.Add(this.dgv_distributionPoints);
            this.groupBox2.Controls.Add(this.cb_dpList);
            this.groupBox2.Controls.Add(this.b_addDP);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(255, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 279);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distribution Points";
            // 
            // b_removeDP
            // 
            this.b_removeDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_removeDP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_removeDP.Location = new System.Drawing.Point(319, 19);
            this.b_removeDP.Name = "b_removeDP";
            this.b_removeDP.Size = new System.Drawing.Size(75, 23);
            this.b_removeDP.TabIndex = 49;
            this.b_removeDP.Text = "Remove";
            this.b_removeDP.UseVisualStyleBackColor = true;
            this.b_removeDP.Click += new System.EventHandler(this.b_removeDP_Click);
            // 
            // dgv_distributionPoints
            // 
            this.dgv_distributionPoints.AllowUserToAddRows = false;
            this.dgv_distributionPoints.AllowUserToDeleteRows = false;
            this.dgv_distributionPoints.AllowUserToResizeRows = false;
            this.dgv_distributionPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_distributionPoints.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_distributionPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_distributionPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_dp_Name,
            this.c_dp_Type,
            this.c_dp_ID,
            this.c_dp_Sitecode,
            this.c_dp_nalPath});
            this.dgv_distributionPoints.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_distributionPoints.Location = new System.Drawing.Point(11, 52);
            this.dgv_distributionPoints.MultiSelect = false;
            this.dgv_distributionPoints.Name = "dgv_distributionPoints";
            this.dgv_distributionPoints.ReadOnly = true;
            this.dgv_distributionPoints.RowHeadersVisible = false;
            this.dgv_distributionPoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_distributionPoints.Size = new System.Drawing.Size(383, 217);
            this.dgv_distributionPoints.TabIndex = 48;
            this.dgv_distributionPoints.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_distributionPoints_RowPrePaint);
            // 
            // c_dp_Name
            // 
            this.c_dp_Name.HeaderText = "Name";
            this.c_dp_Name.Name = "c_dp_Name";
            this.c_dp_Name.ReadOnly = true;
            this.c_dp_Name.Width = 90;
            // 
            // c_dp_Type
            // 
            this.c_dp_Type.HeaderText = "Type";
            this.c_dp_Type.Name = "c_dp_Type";
            this.c_dp_Type.ReadOnly = true;
            this.c_dp_Type.Width = 50;
            // 
            // c_dp_ID
            // 
            this.c_dp_ID.HeaderText = "ID";
            this.c_dp_ID.Name = "c_dp_ID";
            this.c_dp_ID.ReadOnly = true;
            this.c_dp_ID.Visible = false;
            // 
            // c_dp_Sitecode
            // 
            this.c_dp_Sitecode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_dp_Sitecode.HeaderText = "SiteCode";
            this.c_dp_Sitecode.Name = "c_dp_Sitecode";
            this.c_dp_Sitecode.ReadOnly = true;
            // 
            // c_dp_nalPath
            // 
            this.c_dp_nalPath.HeaderText = "NALPath";
            this.c_dp_nalPath.Name = "c_dp_nalPath";
            this.c_dp_nalPath.ReadOnly = true;
            this.c_dp_nalPath.Visible = false;
            // 
            // cb_dpList
            // 
            this.cb_dpList.FormattingEnabled = true;
            this.cb_dpList.Location = new System.Drawing.Point(11, 19);
            this.cb_dpList.Name = "cb_dpList";
            this.cb_dpList.Size = new System.Drawing.Size(176, 21);
            this.cb_dpList.TabIndex = 47;
            this.cb_dpList.SelectedIndexChanged += new System.EventHandler(this.cb_dpList_SelectedIndexChanged);
            // 
            // b_addDP
            // 
            this.b_addDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_addDP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_addDP.Location = new System.Drawing.Point(202, 19);
            this.b_addDP.Name = "b_addDP";
            this.b_addDP.Size = new System.Drawing.Size(111, 23);
            this.b_addDP.TabIndex = 44;
            this.b_addDP.Text = "Add DP";
            this.b_addDP.UseVisualStyleBackColor = true;
            this.b_addDP.Click += new System.EventHandler(this.b_addDP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_deviceType);
            this.groupBox1.Controls.Add(this.b_devicetypeAdd);
            this.groupBox1.Controls.Add(this.tb_deviceType);
            this.groupBox1.Controls.Add(this.b_devicetypeRemove);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(5, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 279);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Groups";
            // 
            // lb_deviceType
            // 
            this.lb_deviceType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_deviceType.FormattingEnabled = true;
            this.lb_deviceType.Location = new System.Drawing.Point(6, 50);
            this.lb_deviceType.Name = "lb_deviceType";
            this.lb_deviceType.Size = new System.Drawing.Size(232, 225);
            this.lb_deviceType.Sorted = true;
            this.lb_deviceType.TabIndex = 40;
            // 
            // b_devicetypeAdd
            // 
            this.b_devicetypeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_devicetypeAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_devicetypeAdd.Location = new System.Drawing.Point(108, 21);
            this.b_devicetypeAdd.Name = "b_devicetypeAdd";
            this.b_devicetypeAdd.Size = new System.Drawing.Size(62, 23);
            this.b_devicetypeAdd.TabIndex = 41;
            this.b_devicetypeAdd.Text = "Add";
            this.b_devicetypeAdd.UseVisualStyleBackColor = true;
            this.b_devicetypeAdd.Click += new System.EventHandler(this.b_devicetypeAdd_Click);
            // 
            // tb_deviceType
            // 
            this.tb_deviceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_deviceType.Location = new System.Drawing.Point(6, 23);
            this.tb_deviceType.Name = "tb_deviceType";
            this.tb_deviceType.Size = new System.Drawing.Size(96, 20);
            this.tb_deviceType.TabIndex = 43;
            // 
            // b_devicetypeRemove
            // 
            this.b_devicetypeRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_devicetypeRemove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_devicetypeRemove.Location = new System.Drawing.Point(176, 21);
            this.b_devicetypeRemove.Name = "b_devicetypeRemove";
            this.b_devicetypeRemove.Size = new System.Drawing.Size(62, 23);
            this.b_devicetypeRemove.TabIndex = 42;
            this.b_devicetypeRemove.Text = "Remove";
            this.b_devicetypeRemove.UseVisualStyleBackColor = true;
            this.b_devicetypeRemove.Click += new System.EventHandler(this.b_devicetypeRemove_Click);
            // 
            // tb_Rules
            // 
            this.tb_Rules.BackColor = System.Drawing.Color.White;
            this.tb_Rules.Controls.Add(this.b_removeselectedRule);
            this.tb_Rules.Controls.Add(this.dgv_Transcript);
            this.tb_Rules.Location = new System.Drawing.Point(4, 22);
            this.tb_Rules.Name = "tb_Rules";
            this.tb_Rules.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Rules.Size = new System.Drawing.Size(1069, 576);
            this.tb_Rules.TabIndex = 0;
            this.tb_Rules.Text = "Rules";
            // 
            // b_removeselectedRule
            // 
            this.b_removeselectedRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_removeselectedRule.Location = new System.Drawing.Point(6, 542);
            this.b_removeselectedRule.Name = "b_removeselectedRule";
            this.b_removeselectedRule.Size = new System.Drawing.Size(119, 23);
            this.b_removeselectedRule.TabIndex = 9;
            this.b_removeselectedRule.Text = "Remove Rule";
            this.b_removeselectedRule.UseVisualStyleBackColor = true;
            this.b_removeselectedRule.Click += new System.EventHandler(this.b_removeselectedRule_Click);
            // 
            // tb_Deployments
            // 
            this.tb_Deployments.Controls.Add(this.b_removeDeployment);
            this.tb_Deployments.Controls.Add(this.dgv_Deployments);
            this.tb_Deployments.Location = new System.Drawing.Point(4, 22);
            this.tb_Deployments.Name = "tb_Deployments";
            this.tb_Deployments.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Deployments.Size = new System.Drawing.Size(1069, 576);
            this.tb_Deployments.TabIndex = 1;
            this.tb_Deployments.Text = "Deployments";
            this.tb_Deployments.UseVisualStyleBackColor = true;
            // 
            // b_removeDeployment
            // 
            this.b_removeDeployment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_removeDeployment.Location = new System.Drawing.Point(6, 542);
            this.b_removeDeployment.Name = "b_removeDeployment";
            this.b_removeDeployment.Size = new System.Drawing.Size(119, 23);
            this.b_removeDeployment.TabIndex = 32;
            this.b_removeDeployment.Text = "Remove  Deployment";
            this.b_removeDeployment.UseVisualStyleBackColor = true;
            this.b_removeDeployment.Click += new System.EventHandler(this.b_removeDeployment_Click);
            // 
            // tb_SecurityScopes
            // 
            this.tb_SecurityScopes.Controls.Add(this.b_removesecurityScope);
            this.tb_SecurityScopes.Controls.Add(this.dgv_SecurityScopes);
            this.tb_SecurityScopes.Location = new System.Drawing.Point(4, 22);
            this.tb_SecurityScopes.Name = "tb_SecurityScopes";
            this.tb_SecurityScopes.Size = new System.Drawing.Size(1069, 576);
            this.tb_SecurityScopes.TabIndex = 2;
            this.tb_SecurityScopes.Text = "Security Scopes";
            this.tb_SecurityScopes.UseVisualStyleBackColor = true;
            // 
            // b_removesecurityScope
            // 
            this.b_removesecurityScope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_removesecurityScope.Location = new System.Drawing.Point(6, 542);
            this.b_removesecurityScope.Name = "b_removesecurityScope";
            this.b_removesecurityScope.Size = new System.Drawing.Size(148, 23);
            this.b_removesecurityScope.TabIndex = 40;
            this.b_removesecurityScope.Text = "Remove Security Scope";
            this.b_removesecurityScope.UseVisualStyleBackColor = true;
            this.b_removesecurityScope.Click += new System.EventHandler(this.b_removesecurityScope_Click);
            // 
            // tb_AvailablePatches
            // 
            this.tb_AvailablePatches.Controls.Add(this.cb_forceScan);
            this.tb_AvailablePatches.Controls.Add(this.cb_runsumCleanup);
            this.tb_AvailablePatches.Controls.Add(this.sc_View);
            this.tb_AvailablePatches.Controls.Add(this.b_createObjects);
            this.tb_AvailablePatches.Controls.Add(this.b_buildPreview);
            this.tb_AvailablePatches.Controls.Add(this.l_totalRows);
            this.tb_AvailablePatches.Controls.Add(this.b_checkforPatches);
            this.tb_AvailablePatches.Location = new System.Drawing.Point(4, 22);
            this.tb_AvailablePatches.Name = "tb_AvailablePatches";
            this.tb_AvailablePatches.Size = new System.Drawing.Size(1069, 576);
            this.tb_AvailablePatches.TabIndex = 4;
            this.tb_AvailablePatches.Text = "Available Patches";
            this.tb_AvailablePatches.UseVisualStyleBackColor = true;
            // 
            // cb_forceScan
            // 
            this.cb_forceScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_forceScan.AutoSize = true;
            this.cb_forceScan.Location = new System.Drawing.Point(448, 541);
            this.cb_forceScan.Name = "cb_forceScan";
            this.cb_forceScan.Size = new System.Drawing.Size(180, 17);
            this.cb_forceScan.TabIndex = 67;
            this.cb_forceScan.Text = "Purge PatchMaster patch cache";
            this.cb_forceScan.UseVisualStyleBackColor = true;
            this.cb_forceScan.CheckedChanged += new System.EventHandler(this.cb_forceScan_CheckedChanged);
            // 
            // cb_runsumCleanup
            // 
            this.cb_runsumCleanup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_runsumCleanup.AutoSize = true;
            this.cb_runsumCleanup.Location = new System.Drawing.Point(645, 541);
            this.cb_runsumCleanup.Name = "cb_runsumCleanup";
            this.cb_runsumCleanup.Size = new System.Drawing.Size(165, 17);
            this.cb_runsumCleanup.TabIndex = 66;
            this.cb_runsumCleanup.Text = "Run SUM Cleanup after Build";
            this.cb_runsumCleanup.UseVisualStyleBackColor = true;
            this.cb_runsumCleanup.CheckedChanged += new System.EventHandler(this.cb_runsumCleanup_CheckedChanged);
            // 
            // sc_View
            // 
            this.sc_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sc_View.Location = new System.Drawing.Point(3, 3);
            this.sc_View.Name = "sc_View";
            this.sc_View.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_View.Panel1
            // 
            this.sc_View.Panel1.Controls.Add(this.dgv_Preview);
            // 
            // sc_View.Panel2
            // 
            this.sc_View.Panel2.Controls.Add(this.dgv_availablePatches);
            this.sc_View.Size = new System.Drawing.Size(1063, 528);
            this.sc_View.SplitterDistance = 192;
            this.sc_View.TabIndex = 65;
            // 
            // dgv_Preview
            // 
            this.dgv_Preview.AllowUserToAddRows = false;
            this.dgv_Preview.AllowUserToDeleteRows = false;
            this.dgv_Preview.AllowUserToOrderColumns = true;
            this.dgv_Preview.AllowUserToResizeRows = false;
            this.dgv_Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Preview.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Preview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Preview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_preview_Type,
            this.c_preview_Name,
            this.c_preview_TotalItems,
            this.c_preview_deviceType});
            this.dgv_Preview.Location = new System.Drawing.Point(3, 3);
            this.dgv_Preview.Name = "dgv_Preview";
            this.dgv_Preview.ReadOnly = true;
            this.dgv_Preview.RowHeadersVisible = false;
            this.dgv_Preview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Preview.Size = new System.Drawing.Size(1057, 186);
            this.dgv_Preview.TabIndex = 60;
            // 
            // c_preview_Type
            // 
            this.c_preview_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_preview_Type.HeaderText = "Type";
            this.c_preview_Type.Name = "c_preview_Type";
            this.c_preview_Type.ReadOnly = true;
            this.c_preview_Type.Width = 56;
            // 
            // c_preview_Name
            // 
            this.c_preview_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_preview_Name.HeaderText = "Name";
            this.c_preview_Name.Name = "c_preview_Name";
            this.c_preview_Name.ReadOnly = true;
            this.c_preview_Name.Width = 60;
            // 
            // c_preview_TotalItems
            // 
            this.c_preview_TotalItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c_preview_TotalItems.HeaderText = "Total Items";
            this.c_preview_TotalItems.Name = "c_preview_TotalItems";
            this.c_preview_TotalItems.ReadOnly = true;
            this.c_preview_TotalItems.Width = 84;
            // 
            // c_preview_deviceType
            // 
            this.c_preview_deviceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_preview_deviceType.HeaderText = "Device Group";
            this.c_preview_deviceType.Name = "c_preview_deviceType";
            this.c_preview_deviceType.ReadOnly = true;
            // 
            // b_createObjects
            // 
            this.b_createObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_createObjects.Location = new System.Drawing.Point(223, 537);
            this.b_createObjects.Name = "b_createObjects";
            this.b_createObjects.Size = new System.Drawing.Size(93, 23);
            this.b_createObjects.TabIndex = 63;
            this.b_createObjects.Text = "Build";
            this.b_createObjects.UseVisualStyleBackColor = true;
            this.b_createObjects.Click += new System.EventHandler(this.b_createObjects_Click);
            // 
            // b_buildPreview
            // 
            this.b_buildPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_buildPreview.Location = new System.Drawing.Point(124, 537);
            this.b_buildPreview.Name = "b_buildPreview";
            this.b_buildPreview.Size = new System.Drawing.Size(93, 23);
            this.b_buildPreview.TabIndex = 62;
            this.b_buildPreview.Text = "Refresh SUGs";
            this.b_buildPreview.UseVisualStyleBackColor = true;
            this.b_buildPreview.Click += new System.EventHandler(this.buildPreview_Click);
            // 
            // l_totalRows
            // 
            this.l_totalRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_totalRows.AutoSize = true;
            this.l_totalRows.Location = new System.Drawing.Point(830, 542);
            this.l_totalRows.Name = "l_totalRows";
            this.l_totalRows.Size = new System.Drawing.Size(142, 13);
            this.l_totalRows.TabIndex = 37;
            this.l_totalRows.Text = "Total patches: - Total SUGs:";
            // 
            // b_checkforPatches
            // 
            this.b_checkforPatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_checkforPatches.Location = new System.Drawing.Point(9, 537);
            this.b_checkforPatches.Name = "b_checkforPatches";
            this.b_checkforPatches.Size = new System.Drawing.Size(109, 23);
            this.b_checkforPatches.TabIndex = 33;
            this.b_checkforPatches.Text = "Check for Patches";
            this.b_checkforPatches.UseVisualStyleBackColor = true;
            this.b_checkforPatches.Click += new System.EventHandler(this.b_checkforPatches_Click);
            // 
            // tb_IgnorePatches
            // 
            this.tb_IgnorePatches.Controls.Add(this.dgv_ignorePatches);
            this.tb_IgnorePatches.Location = new System.Drawing.Point(4, 22);
            this.tb_IgnorePatches.Name = "tb_IgnorePatches";
            this.tb_IgnorePatches.Padding = new System.Windows.Forms.Padding(3);
            this.tb_IgnorePatches.Size = new System.Drawing.Size(1069, 576);
            this.tb_IgnorePatches.TabIndex = 3;
            this.tb_IgnorePatches.Text = "Ignore Patches";
            this.tb_IgnorePatches.UseVisualStyleBackColor = true;
            // 
            // tb_SUMaint
            // 
            this.tb_SUMaint.Controls.Add(this.b_locatesupersedPatches);
            this.tb_SUMaint.Controls.Add(this.dgv_supersededPatches);
            this.tb_SUMaint.Controls.Add(this.b_removesupersededPatches);
            this.tb_SUMaint.Location = new System.Drawing.Point(4, 22);
            this.tb_SUMaint.Name = "tb_SUMaint";
            this.tb_SUMaint.Size = new System.Drawing.Size(1069, 576);
            this.tb_SUMaint.TabIndex = 11;
            this.tb_SUMaint.Text = "SUM Maintenance";
            this.tb_SUMaint.UseVisualStyleBackColor = true;
            // 
            // b_locatesupersedPatches
            // 
            this.b_locatesupersedPatches.Location = new System.Drawing.Point(10, 8);
            this.b_locatesupersedPatches.Name = "b_locatesupersedPatches";
            this.b_locatesupersedPatches.Size = new System.Drawing.Size(158, 23);
            this.b_locatesupersedPatches.TabIndex = 9;
            this.b_locatesupersedPatches.Text = "Find Superseded Patches";
            this.b_locatesupersedPatches.UseVisualStyleBackColor = true;
            this.b_locatesupersedPatches.Click += new System.EventHandler(this.b_locatesupersedPatches_Click);
            // 
            // dgv_supersededPatches
            // 
            this.dgv_supersededPatches.AllowUserToAddRows = false;
            this.dgv_supersededPatches.AllowUserToDeleteRows = false;
            this.dgv_supersededPatches.AllowUserToResizeRows = false;
            this.dgv_supersededPatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_supersededPatches.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_supersededPatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supersededPatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_supersededPatch_SUG,
            this.c_supersededPatch_SUGCIID,
            this.c_supersededPatch_PatchID,
            this.c_supersededPatch_PatchKBID,
            this.c_supersededPatch_Name});
            this.dgv_supersededPatches.Location = new System.Drawing.Point(3, 43);
            this.dgv_supersededPatches.MultiSelect = false;
            this.dgv_supersededPatches.Name = "dgv_supersededPatches";
            this.dgv_supersededPatches.ReadOnly = true;
            this.dgv_supersededPatches.RowHeadersVisible = false;
            this.dgv_supersededPatches.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_supersededPatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_supersededPatches.ShowEditingIcon = false;
            this.dgv_supersededPatches.Size = new System.Drawing.Size(1063, 530);
            this.dgv_supersededPatches.TabIndex = 8;
            // 
            // c_supersededPatch_SUG
            // 
            this.c_supersededPatch_SUG.HeaderText = "Software Update Group";
            this.c_supersededPatch_SUG.Name = "c_supersededPatch_SUG";
            this.c_supersededPatch_SUG.ReadOnly = true;
            // 
            // c_supersededPatch_SUGCIID
            // 
            this.c_supersededPatch_SUGCIID.HeaderText = "SUG CI_ID";
            this.c_supersededPatch_SUGCIID.Name = "c_supersededPatch_SUGCIID";
            this.c_supersededPatch_SUGCIID.ReadOnly = true;
            // 
            // c_supersededPatch_PatchID
            // 
            this.c_supersededPatch_PatchID.HeaderText = "Patch CI_ID";
            this.c_supersededPatch_PatchID.Name = "c_supersededPatch_PatchID";
            this.c_supersededPatch_PatchID.ReadOnly = true;
            // 
            // c_supersededPatch_PatchKBID
            // 
            this.c_supersededPatch_PatchKBID.HeaderText = "KB ID";
            this.c_supersededPatch_PatchKBID.Name = "c_supersededPatch_PatchKBID";
            this.c_supersededPatch_PatchKBID.ReadOnly = true;
            this.c_supersededPatch_PatchKBID.Width = 80;
            // 
            // c_supersededPatch_Name
            // 
            this.c_supersededPatch_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_supersededPatch_Name.HeaderText = "Name";
            this.c_supersededPatch_Name.Name = "c_supersededPatch_Name";
            this.c_supersededPatch_Name.ReadOnly = true;
            // 
            // b_removesupersededPatches
            // 
            this.b_removesupersededPatches.Location = new System.Drawing.Point(174, 8);
            this.b_removesupersededPatches.Name = "b_removesupersededPatches";
            this.b_removesupersededPatches.Size = new System.Drawing.Size(158, 23);
            this.b_removesupersededPatches.TabIndex = 5;
            this.b_removesupersededPatches.Text = "Remove Superseded Patches";
            this.b_removesupersededPatches.UseVisualStyleBackColor = true;
            this.b_removesupersededPatches.Click += new System.EventHandler(this.b_removesupersededPatches_Click);
            // 
            // tb_WSUS
            // 
            this.tb_WSUS.Controls.Add(this.splitContainer3);
            this.tb_WSUS.Location = new System.Drawing.Point(4, 22);
            this.tb_WSUS.Name = "tb_WSUS";
            this.tb_WSUS.Size = new System.Drawing.Size(1069, 576);
            this.tb_WSUS.TabIndex = 10;
            this.tb_WSUS.Text = "WSUS";
            this.tb_WSUS.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tb_wsusPort);
            this.splitContainer3.Panel1.Controls.Add(this.label13);
            this.splitContainer3.Panel1.Controls.Add(this.tb_wsusName);
            this.splitContainer3.Panel1.Controls.Add(this.label11);
            this.splitContainer3.Panel1.Controls.Add(this.cb_wsus_dryRun);
            this.splitContainer3.Panel1.Controls.Add(this.b_invokewsusCleanup);
            this.splitContainer3.Panel1.Controls.Add(this.b_getwsusPatches);
            this.splitContainer3.Panel1.Controls.Add(this.checkBox3);
            this.splitContainer3.Panel1.Controls.Add(this.checkBox4);
            this.splitContainer3.Panel1.Controls.Add(this.dgv_wsus_Patches);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label18);
            this.splitContainer3.Panel2.Controls.Add(this.label17);
            this.splitContainer3.Panel2.Controls.Add(this.label14);
            this.splitContainer3.Panel2.Controls.Add(this.cb_wsus_Text);
            this.splitContainer3.Panel2.Controls.Add(this.cb_wsusAction);
            this.splitContainer3.Panel2.Controls.Add(this.cb_wsus_Type);
            this.splitContainer3.Panel2.Controls.Add(this.b_adddwsusRule);
            this.splitContainer3.Panel2.Controls.Add(this.dgv_cmdCollection);
            this.splitContainer3.Size = new System.Drawing.Size(1063, 570);
            this.splitContainer3.SplitterDistance = 673;
            this.splitContainer3.TabIndex = 16;
            // 
            // tb_wsusPort
            // 
            this.tb_wsusPort.Location = new System.Drawing.Point(266, 38);
            this.tb_wsusPort.Name = "tb_wsusPort";
            this.tb_wsusPort.Size = new System.Drawing.Size(100, 20);
            this.tb_wsusPort.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "WSUS Port";
            // 
            // tb_wsusName
            // 
            this.tb_wsusName.Location = new System.Drawing.Point(92, 38);
            this.tb_wsusName.Name = "tb_wsusName";
            this.tb_wsusName.Size = new System.Drawing.Size(100, 20);
            this.tb_wsusName.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "WSUS Server";
            // 
            // cb_wsus_dryRun
            // 
            this.cb_wsus_dryRun.AutoSize = true;
            this.cb_wsus_dryRun.Enabled = false;
            this.cb_wsus_dryRun.Location = new System.Drawing.Point(136, 12);
            this.cb_wsus_dryRun.Name = "cb_wsus_dryRun";
            this.cb_wsus_dryRun.Size = new System.Drawing.Size(60, 17);
            this.cb_wsus_dryRun.TabIndex = 19;
            this.cb_wsus_dryRun.Text = "Dry run";
            this.cb_wsus_dryRun.UseVisualStyleBackColor = true;
            // 
            // b_invokewsusCleanup
            // 
            this.b_invokewsusCleanup.Location = new System.Drawing.Point(562, 12);
            this.b_invokewsusCleanup.Name = "b_invokewsusCleanup";
            this.b_invokewsusCleanup.Size = new System.Drawing.Size(99, 23);
            this.b_invokewsusCleanup.TabIndex = 18;
            this.b_invokewsusCleanup.Text = "WSUS Cleanup";
            this.b_invokewsusCleanup.UseVisualStyleBackColor = true;
            this.b_invokewsusCleanup.Click += new System.EventHandler(this.b_invokewsusCleanup_Click);
            // 
            // b_getwsusPatches
            // 
            this.b_getwsusPatches.Enabled = false;
            this.b_getwsusPatches.Location = new System.Drawing.Point(12, 9);
            this.b_getwsusPatches.Name = "b_getwsusPatches";
            this.b_getwsusPatches.Size = new System.Drawing.Size(118, 23);
            this.b_getwsusPatches.TabIndex = 17;
            this.b_getwsusPatches.Text = "Process Patches";
            this.b_getwsusPatches.UseVisualStyleBackColor = true;
            this.b_getwsusPatches.Click += new System.EventHandler(this.b_getwsusPatches_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(451, 16);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(105, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Reindex SUSDB";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(321, 16);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(124, 17);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Remove using SQL?";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // dgv_wsus_Patches
            // 
            this.dgv_wsus_Patches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_wsus_Patches.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_wsus_Patches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_wsus_Patches.Location = new System.Drawing.Point(12, 65);
            this.dgv_wsus_Patches.MultiSelect = false;
            this.dgv_wsus_Patches.Name = "dgv_wsus_Patches";
            this.dgv_wsus_Patches.ReadOnly = true;
            this.dgv_wsus_Patches.Size = new System.Drawing.Size(649, 492);
            this.dgv_wsus_Patches.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(172, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Text";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(81, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Action";
            // 
            // cb_wsus_Text
            // 
            this.cb_wsus_Text.Location = new System.Drawing.Point(175, 25);
            this.cb_wsus_Text.Name = "cb_wsus_Text";
            this.cb_wsus_Text.Size = new System.Drawing.Size(127, 20);
            this.cb_wsus_Text.TabIndex = 25;
            // 
            // cb_wsusAction
            // 
            this.cb_wsusAction.FormattingEnabled = true;
            this.cb_wsusAction.Items.AddRange(new object[] {
            "Decline",
            "SQL"});
            this.cb_wsusAction.Location = new System.Drawing.Point(12, 25);
            this.cb_wsusAction.Name = "cb_wsusAction";
            this.cb_wsusAction.Size = new System.Drawing.Size(66, 21);
            this.cb_wsusAction.TabIndex = 24;
            // 
            // cb_wsus_Type
            // 
            this.cb_wsus_Type.FormattingEnabled = true;
            this.cb_wsus_Type.Items.AddRange(new object[] {
            "Superseded",
            "Product",
            "Classification",
            "Search",
            "Reindex",
            "Delete Obsolete"});
            this.cb_wsus_Type.Location = new System.Drawing.Point(84, 24);
            this.cb_wsus_Type.Name = "cb_wsus_Type";
            this.cb_wsus_Type.Size = new System.Drawing.Size(85, 21);
            this.cb_wsus_Type.TabIndex = 23;
            // 
            // b_adddwsusRule
            // 
            this.b_adddwsusRule.Location = new System.Drawing.Point(308, 23);
            this.b_adddwsusRule.Name = "b_adddwsusRule";
            this.b_adddwsusRule.Size = new System.Drawing.Size(75, 23);
            this.b_adddwsusRule.TabIndex = 22;
            this.b_adddwsusRule.Text = "Add";
            this.b_adddwsusRule.UseVisualStyleBackColor = true;
            this.b_adddwsusRule.Click += new System.EventHandler(this.b_adddwsusRule_Click);
            // 
            // dgv_cmdCollection
            // 
            this.dgv_cmdCollection.AllowUserToAddRows = false;
            this.dgv_cmdCollection.AllowUserToDeleteRows = false;
            this.dgv_cmdCollection.AllowUserToResizeRows = false;
            this.dgv_cmdCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cmdCollection.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_cmdCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cmdCollection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_cmdCollection_Name,
            this.c_cmdCollection_Type,
            this.c_wsus_Text});
            this.dgv_cmdCollection.Location = new System.Drawing.Point(12, 96);
            this.dgv_cmdCollection.MultiSelect = false;
            this.dgv_cmdCollection.Name = "dgv_cmdCollection";
            this.dgv_cmdCollection.ReadOnly = true;
            this.dgv_cmdCollection.RowHeadersVisible = false;
            this.dgv_cmdCollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cmdCollection.ShowEditingIcon = false;
            this.dgv_cmdCollection.Size = new System.Drawing.Size(362, 461);
            this.dgv_cmdCollection.TabIndex = 15;
            // 
            // c_cmdCollection_Name
            // 
            this.c_cmdCollection_Name.HeaderText = "Action";
            this.c_cmdCollection_Name.Name = "c_cmdCollection_Name";
            this.c_cmdCollection_Name.ReadOnly = true;
            // 
            // c_cmdCollection_Type
            // 
            this.c_cmdCollection_Type.HeaderText = "Type";
            this.c_cmdCollection_Type.Name = "c_cmdCollection_Type";
            this.c_cmdCollection_Type.ReadOnly = true;
            this.c_cmdCollection_Type.Width = 50;
            // 
            // c_wsus_Text
            // 
            this.c_wsus_Text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_wsus_Text.HeaderText = "Text";
            this.c_wsus_Text.Name = "c_wsus_Text";
            this.c_wsus_Text.ReadOnly = true;
            // 
            // tb_Log
            // 
            this.tb_Log.Controls.Add(this.dgv_Logging);
            this.tb_Log.Location = new System.Drawing.Point(4, 22);
            this.tb_Log.Name = "tb_Log";
            this.tb_Log.Size = new System.Drawing.Size(1069, 576);
            this.tb_Log.TabIndex = 8;
            this.tb_Log.Text = "Log";
            this.tb_Log.UseVisualStyleBackColor = true;
            // 
            // dgv_Logging
            // 
            this.dgv_Logging.AllowUserToAddRows = false;
            this.dgv_Logging.AllowUserToDeleteRows = false;
            this.dgv_Logging.AllowUserToOrderColumns = true;
            this.dgv_Logging.AllowUserToResizeRows = false;
            this.dgv_Logging.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Logging.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Logging.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Logging.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_log_Text});
            this.dgv_Logging.Location = new System.Drawing.Point(3, 2);
            this.dgv_Logging.Name = "dgv_Logging";
            this.dgv_Logging.ReadOnly = true;
            this.dgv_Logging.RowHeadersVisible = false;
            this.dgv_Logging.Size = new System.Drawing.Size(1063, 570);
            this.dgv_Logging.TabIndex = 0;
            // 
            // c_log_Text
            // 
            this.c_log_Text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_log_Text.HeaderText = "";
            this.c_log_Text.Name = "c_log_Text";
            this.c_log_Text.ReadOnly = true;
            this.c_log_Text.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tb_About
            // 
            this.tb_About.Controls.Add(this.splitContainer2);
            this.tb_About.Location = new System.Drawing.Point(4, 22);
            this.tb_About.Name = "tb_About";
            this.tb_About.Padding = new System.Windows.Forms.Padding(3);
            this.tb_About.Size = new System.Drawing.Size(1069, 576);
            this.tb_About.TabIndex = 9;
            this.tb_About.Text = "About";
            this.tb_About.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(6, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtb_tAbout);
            this.splitContainer2.Size = new System.Drawing.Size(1057, 567);
            this.splitContainer2.SplitterDistance = 246;
            this.splitContainer2.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.l_Freeware);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.pb_bigLogo);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1045, 232);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 7;
            // 
            // l_Freeware
            // 
            this.l_Freeware.AutoSize = true;
            this.l_Freeware.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Freeware.Location = new System.Drawing.Point(83, 51);
            this.l_Freeware.Name = "l_Freeware";
            this.l_Freeware.Size = new System.Drawing.Size(146, 13);
            this.l_Freeware.TabIndex = 4;
            this.l_Freeware.Text = "Freeware - Community Tool";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Version 1.7 - By Robert Marshall (@RobMVP)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(5, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(289, 98);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "ConfigMgr SUM automation and Reporting SUG tool\n\n\nFull instructions can be found " +
    "on the TechNet Gallery page for this tool.\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "PatchMaster";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(412, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "MVP Summit Hackathon 2017 (Not related to PatchMaster just a cool event I attende" +
    "d)";
            // 
            // pb_bigLogo
            // 
            this.pb_bigLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_bigLogo.Location = new System.Drawing.Point(15, 12);
            this.pb_bigLogo.Name = "pb_bigLogo";
            this.pb_bigLogo.Size = new System.Drawing.Size(712, 199);
            this.pb_bigLogo.TabIndex = 0;
            this.pb_bigLogo.TabStop = false;
            // 
            // rtb_tAbout
            // 
            this.rtb_tAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_tAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_tAbout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_tAbout.Location = new System.Drawing.Point(19, 13);
            this.rtb_tAbout.Name = "rtb_tAbout";
            this.rtb_tAbout.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_tAbout.Size = new System.Drawing.Size(1015, 284);
            this.rtb_tAbout.TabIndex = 2;
            this.rtb_tAbout.Text = resources.GetString("rtb_tAbout.Text");
            this.rtb_tAbout.TextChanged += new System.EventHandler(this.rtb_tAbout_TextChanged);
            // 
            // pb_waitImage
            // 
            this.pb_waitImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_waitImage.Location = new System.Drawing.Point(-7, -1);
            this.pb_waitImage.Name = "pb_waitImage";
            this.pb_waitImage.Size = new System.Drawing.Size(1077, 602);
            this.pb_waitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_waitImage.TabIndex = 39;
            this.pb_waitImage.TabStop = false;
            this.pb_waitImage.Visible = false;
            // 
            // cmt_removeignoredPatch
            // 
            this.cmt_removeignoredPatch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rptsmi_removeignoredPatch});
            this.cmt_removeignoredPatch.Name = "cmt_removeignoredPatch";
            this.cmt_removeignoredPatch.Size = new System.Drawing.Size(147, 26);
            // 
            // rptsmi_removeignoredPatch
            // 
            this.rptsmi_removeignoredPatch.Name = "rptsmi_removeignoredPatch";
            this.rptsmi_removeignoredPatch.Size = new System.Drawing.Size(146, 22);
            this.rptsmi_removeignoredPatch.Text = "Restore Patch";
            this.rptsmi_removeignoredPatch.Click += new System.EventHandler(this.rptsmi_removeignoredPatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1063, 593);
            this.Controls.Add(this.tc_Main);
            this.Controls.Add(this.pb_waitImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patch Master - Version 1.7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transcript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Deployments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_availablePatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ignorePatches)).EndInit();
            this.cmt_Patch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SecurityScopes)).EndInit();
            this.tc_Main.ResumeLayout(false);
            this.tb_Config.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_downloadRetry)).EndInit();
            this.gb_namingBar.ResumeLayout(false);
            this.gb_namingBar.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Tom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_distributionPoints)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tb_Rules.ResumeLayout(false);
            this.tb_Deployments.ResumeLayout(false);
            this.tb_SecurityScopes.ResumeLayout(false);
            this.tb_AvailablePatches.ResumeLayout(false);
            this.tb_AvailablePatches.PerformLayout();
            this.sc_View.Panel1.ResumeLayout(false);
            this.sc_View.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_View)).EndInit();
            this.sc_View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Preview)).EndInit();
            this.tb_IgnorePatches.ResumeLayout(false);
            this.tb_SUMaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supersededPatches)).EndInit();
            this.tb_WSUS.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_wsus_Patches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmdCollection)).EndInit();
            this.tb_Log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Logging)).EndInit();
            this.tb_About.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_bigLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_waitImage)).EndInit();
            this.cmt_removeignoredPatch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_packagesourcePath;
        private System.Windows.Forms.TextBox tb_packageFolder;
        private System.Windows.Forms.DataGridView dgv_Transcript;
        private System.Windows.Forms.TextBox tb_ooc_Tag;
        private System.Windows.Forms.DataGridView dgv_Deployments;
        private System.Windows.Forms.DataGridView dgv_availablePatches;
        private System.Windows.Forms.DataGridView dgv_ignorePatches;
        private System.Windows.Forms.DataGridView dgv_SecurityScopes;
        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tb_Rules;
        private System.Windows.Forms.TabPage tb_AvailablePatches;
        private System.Windows.Forms.TabPage tb_Deployments;
        private System.Windows.Forms.TabPage tb_SecurityScopes;
        private System.Windows.Forms.TabPage tb_IgnorePatches;
        private System.Windows.Forms.TabPage tb_Config;
        private System.Windows.Forms.FlowLayoutPanel flp_namingSelections;
        private System.Windows.Forms.Button b_addProduct;
        private System.Windows.Forms.TextBox tb_addTextbox;
        private System.Windows.Forms.Button b_addOOC;
        private System.Windows.Forms.Button b_addArchitecture;
        private System.Windows.Forms.Button b_addLanguage;
        private System.Windows.Forms.Button b_addClassification;
        private System.Windows.Forms.Button b_addYear;
        private System.Windows.Forms.Button b_addMonth;
        private System.Windows.Forms.Button b_addDay;
        private System.Windows.Forms.ComboBox cb_patchnamingDelimiter;
        private System.Windows.Forms.TabPage tb_Log;
        private System.Windows.Forms.DataGridView dgv_Logging;
        private System.Windows.Forms.CheckBox cb_unlocknamingBar;
        private System.Windows.Forms.Button b_createPath;
        private System.Windows.Forms.Button b_checkforPatches;
        private System.Windows.Forms.DataGridView dgv_Preview;
        private System.Windows.Forms.Button b_buildPreview;
        private System.Windows.Forms.Label l_totalRows;
        private System.Windows.Forms.TextBox tb_deviceType;
        private System.Windows.Forms.Button b_devicetypeRemove;
        private System.Windows.Forms.Button b_devicetypeAdd;
        private System.Windows.Forms.ListBox lb_deviceType;
        private System.Windows.Forms.Button b_createObjects;
        private System.Windows.Forms.ComboBox cb_dpList;
        private System.Windows.Forms.Button b_addDP;
        private System.Windows.Forms.DataGridView dgv_distributionPoints;
        private System.Windows.Forms.Button b_removeselectedRule;
        private System.Windows.Forms.Button b_removeDeployment;
        private System.Windows.Forms.Button b_removesecurityScope;
        private System.Windows.Forms.CheckBox cb_timeMachine;
        private System.Windows.Forms.ComboBox cb_timemachine_Year;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_timemachine_Month;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_timemachine_Day;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cb_deployment_allowMetered;
        private System.Windows.Forms.CheckBox cb_deployment_usemsUpdates;
        private System.Windows.Forms.CheckBox cb_deployment_defaultFallback;
        private System.Windows.Forms.CheckBox cb_deployment_downloadNeighbour;
        private System.Windows.Forms.CheckBox cb_deployment_Evaluation;
        private System.Windows.Forms.CheckBox cb_deployment_commitFilter;
        private System.Windows.Forms.CheckBox cb_deployment_supressWorkstations;
        private System.Windows.Forms.CheckBox cb_deployment_supressServers;
        private System.Windows.Forms.CheckBox cb_deployment_deadlinerestart;
        private System.Windows.Forms.CheckBox cb_deployment_delayEnforcement;
        private System.Windows.Forms.CheckBox cb_deployment_enableWOL;
        private System.Windows.Forms.CheckBox cb_deployment_useBranchcache;
        private System.Windows.Forms.Button b_removeDP;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cb_createreportingSUGS;
        private System.Windows.Forms.Button b_addReporting;
        private System.Windows.Forms.ContextMenuStrip cmt_Patch;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ignorePatch;
        private System.Windows.Forms.ContextMenuStrip cmt_removeignoredPatch;
        private System.Windows.Forms.ToolStripMenuItem rptsmi_removeignoredPatch;
        private System.Windows.Forms.PictureBox pb_waitImage;
        private System.Windows.Forms.TabPage tb_About;
        private System.Windows.Forms.PictureBox pb_bigLogo;
        private System.Windows.Forms.RichTextBox rtb_tAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_Freeware;
        private System.Windows.Forms.CheckBox cb_deployment_notifyUser;
        private System.Windows.Forms.CheckBox cb_deployment_logtowinEvent;
        private System.Windows.Forms.CheckBox cb_deployment_limitstatemsgverbosity;
        private System.Windows.Forms.CheckBox cb_deployment_disablemomAlerts;
        private System.Windows.Forms.CheckBox cb_deployment_useruiExperience;
        private System.Windows.Forms.CheckBox cb_deployment_raisemomalertsonFailure;
        private System.Windows.Forms.CheckBox cb_deployment_useutcTimes;
        private System.Windows.Forms.CheckBox cb_deployment_senddetailednonCompliance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_deploymentdeviceGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_deployment_statemessageVerbosity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_deployment_statemessagePriority;
        private System.Windows.Forms.SplitContainer sc_View;
        private System.Windows.Forms.GroupBox gb_namingBar;
        private System.Windows.Forms.CheckBox cb_deployment_overrideserviceWindows;
        private System.Windows.Forms.Button b_Debug;
        private System.Windows.Forms.CheckBox cb_deployment_RandomizationEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ignorepatches_KBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ignorepatches_LocalizedDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ignorepatches_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ignorepatches_Classification;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_dp_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_dp_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_dp_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_dp_Sitecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_dp_nalPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ap_deviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ap_PatchKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ap_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_app_Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ap_Classification;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ap_Architecture;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ap_DateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ap_dateReleased;
        private System.Windows.Forms.TabPage tb_WSUS;
        private System.Windows.Forms.PictureBox pb_Tom;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage tb_SUMaint;
        private System.Windows.Forms.DataGridView dgv_supersededPatches;
        private System.Windows.Forms.Button b_removesupersededPatches;
        private System.Windows.Forms.DataGridView dgv_wsus_Patches;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button b_locatesupersedPatches;
        private System.Windows.Forms.DataGridView dgv_cmdCollection;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cb_wsus_Text;
        private System.Windows.Forms.ComboBox cb_wsusAction;
        private System.Windows.Forms.ComboBox cb_wsus_Type;
        private System.Windows.Forms.Button b_adddwsusRule;
        private System.Windows.Forms.Button b_getwsusPatches;
        private System.Windows.Forms.Button b_invokewsusCleanup;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_cmdCollection_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_cmdCollection_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_wsus_Text;
        private System.Windows.Forms.CheckBox cb_wsus_dryRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_supersededPatch_SUG;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_supersededPatch_SUGCIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_supersededPatch_PatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_supersededPatch_PatchKBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_supersededPatch_Name;
        private System.Windows.Forms.CheckBox cb_runsumCleanup;
        private System.Windows.Forms.TextBox tb_wsusPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_wsusName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_preview_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_preview_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_preview_TotalItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_preview_deviceType;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_scoping_deviceType;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_scoping_Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_scoping_Scope;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_deployments_DeviceType;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_deployment_coltarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_deployment_depTag;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_deployment_availReq;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_deployment_availdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_deployment_availTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_deployment_deadlinedateOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_deployment_deadlineTime;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nud_downloadRetry;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button b_openLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_transcript_deviceType;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_transcript_Architecture;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_transcript_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_transcript_Classifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_transcript_Languages;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_transcript_includeRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_transcript_ignoreBuilds;
        private System.Windows.Forms.CheckBox cb_rollupOffice;
        private System.Windows.Forms.CheckBox cb_rollupserverOS;
        private System.Windows.Forms.CheckBox cb_rollupclientOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_log_Text;
        private System.Windows.Forms.CheckBox cb_forceScan;
        private System.Windows.Forms.Label label16;
    }
}

