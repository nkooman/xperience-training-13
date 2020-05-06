﻿using System;
using System.Web.UI;
using System.Web.UI.WebControls;

using CMS.Base.Web.UI;
using CMS.Helpers;
using CMS.UIControls;
using CMS.WorkflowEngine;

/// <summary>
/// Code behind for control used to automation designer.
/// </summary>
public partial class CMSModules_ContactManagement_Controls_UI_Automation_AutomationDesigner : GraphDesigner
{
    #region "Private variables"

    private int mWorkflowId;

    private WorkflowInfo mWorkflow;

    private WebControl mIcon; 

    #endregion


    #region "Public properties"

    /// <summary>
    /// Gets the icon control.
    /// </summary>
    private WebControl Icon => mIcon ?? (mIcon = GetIcon());


    protected override UniGraph UniGraph => uniGraph;


    protected override CMSPanel ToolbarContainer => toolbarContainer;


    protected override IServiceChecker ServiceChecker => serviceChecker;


    /// <summary>
    /// Property used to select workflow to be printed.
    /// </summary>
    public override int WorkflowID
    {
        get
        {
            return mWorkflowId;
        }
        set
        {
            mWorkflowId = value;
            mWorkflow = null;
        }
    }


    /// <summary>
    /// Property of workflow info object.
    /// </summary>
    protected override WorkflowInfo Workflow
    {
        get
        {
            if (mWorkflow == null)
            {
                mWorkflow = WorkflowInfoProvider.GetWorkflowInfo(WorkflowID);
                if ((mWorkflow != null) && (mWorkflow.WorkflowType != WorkflowTypeEnum.Automation))
                {
                    RedirectToAccessDenied(GetString("workflow.type.notsupported"));
                    mWorkflow = null;
                }
            }
            return mWorkflow;
        }
    }


    /// <summary>
    /// Indicates whether changes can be made.
    /// </summary>
    public override bool ReadOnly
    {
        get
        {
            return base.ReadOnly;
        }
        set
        {
            base.ReadOnly = value;
            toolbar.Visible = !value;
            pnlHeader.Visible = !value;
            ToolbarContainer.Visible = !value;
            ServiceChecker.StopProcessing = value;
        }
    }


    /// <summary>
    /// In this control visibility has same function as stopping processing. Only values are inversed.
    /// </summary>
    public override bool StopProcessing
    {
        get
        {
            return !Visible;
        }
        set
        {
            Visible = !value;
        }
    }


    /// <summary>
    /// Propagates visibility to toolbar and header.
    /// </summary>
    public override bool Visible
    {
        get
        {
            return base.Visible;
        }
        set
        {
            ToolbarContainer.Visible = value;
            toolbar.Visible = value;
            pnlHeader.Visible = value;
            base.Visible = value;
        }
    }

    #endregion


    #region "Event handlers and methods"

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        if (!Visible)
        {
            return;
        }
        if (Page is CMSPage page)
        {
            page.EnsureScriptManager();
        }

        CheckService();
        InitializeToolbar();
        InitializeAutosave();
        InitializeHeader();
    }


    /// <summary>
    /// Prints the graph.
    /// </summary>
    /// <param name="e">Arguments of event</param>
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);

        if (!Visible)
        {
            return;
        }
        SetGraphConfiguration();
        if (!ReadOnly)
        {
            UniGraph.RegisterService(ServiceUrl);
        }
    }


    protected override void SetGraphConfiguration()
    {
        base.SetGraphConfiguration();

        UniGraph.GraphConfiguration.Addresses["Properties"] = GetPropertiesUrl();
        UniGraph.PropertiesId = propertiesFrame.ClientID;
        UniGraph.AutosaveId = pnlAutosaveWrapper.ClientID;
    }


    private static string GetPropertiesUrl()
    {
        var url = "~/CMSModules/ContactManagement/Pages/Tools/Automation/Process/Properties/ProcessProperties.aspx";
        return URLHelper.GetAbsoluteUrl(url);
    }


    /// <summary>
    /// Prepares control for read only/editable mode.
    /// </summary>
    private void InitializeToolbar()
    {
        ToolbarContainer.CssClass += " " + uniGraph.JsObjectName;
        toolbar.JsGraphObject = UniGraph.JsObjectName;
        toolbar.Workflow = Workflow;
    }


    private void InitializeAutosave()
    {
        pnlAutosave.AddConfirmation(GetString("general.changessaved"));
        pnlAutosave.ContainerCssClass = "hide";
    }


    private void InitializeHeader()
    {
        if (Workflow == null || ReadOnly)
        {
            return;
        }

        Icon.RemoveCssClass(Workflow.WorkflowEnabled ? "disabled" : "enabled");
        Icon.AddCssClass(Workflow.WorkflowEnabled ? "enabled" : "disabled");
        lblState.Text = Workflow.WorkflowEnabled ? GetString("automationdesigner.processactive") : GetString("automationdesigner.processinactive");
        btnToggleState.Text = Workflow.WorkflowEnabled ? GetString("general.disable") : GetString("general.enable");
    }


    private WebControl GetIcon()
    {
        var icon = new WebControl(HtmlTextWriterTag.I);
        icon.Attributes.Add("aria-hidden", "true");
        icon.AddCssClass("cms-icon-50");
        icon.AddCssClass("icon-circle");
        icnState.Controls.AddAt(0, icon);

        return icon;
    }


    protected void ToggleState(object sender, EventArgs args)
    {
        if (Workflow == null || ReadOnly)
        {
            return;
        }

        Workflow.WorkflowEnabled = !Workflow.WorkflowEnabled;
        WorkflowInfoProvider.SetWorkflowInfo(Workflow);

        InitializeHeader();
    }

    #endregion
}