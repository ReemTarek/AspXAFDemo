
namespace TestXafDemo.Module.Controllers
{
    partial class ViewController1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpleAction1 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // simpleAction1
            // 
            this.simpleAction1.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.simpleAction1.Caption = "Test";
            this.simpleAction1.Category = "ObjectsCreation";
            this.simpleAction1.ConfirmationMessage = "are you sure you want to add new customer?";
            this.simpleAction1.Id = "82333c90-8d9d-436a-a4f5-fc61287fa883";
            this.simpleAction1.ImageName = "BO_Person";
            this.simpleAction1.ToolTip = null;
            this.simpleAction1.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction1_Execute);
            // 
            // ViewController1
            // 
            this.Actions.Add(this.simpleAction1);
            this.TargetViewId = "Customer_ListView";
            this.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction simpleAction1;
    }
}
