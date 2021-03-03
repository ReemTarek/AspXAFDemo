using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using TestXafDemo.Module.BusinessObjects.Marketing;
using TestXafDemo.Module.BusinessObjects;

namespace TestXafDemo.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ViewController1 : ViewController
    {
        Session workSession = new Session();

        public ViewController1()
        {
            InitializeComponent();
            RegisterActions(components);
            simpleAction1.ExecuteCompleted += simpleAction1_ExecuteCompleted;
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

            // string cs = ConfigurationManager.ConnectionStrings["ConnectionStringXPO"].ConnectionString;
            //var contact = new Contact(uow);
            //contact.FirstName = "Alice";
            //contact.LastName = "Smith";
            //uow.CommitChanges();
            //var NewID =    new Guid();
            //   Person Newperson = new Person(workSession);
            //  // Newperson.Oid = NewID; 
            //   Newperson.LastName = "test";
            //   Newperson.FirstName = "reem";
            //   Newperson.MiddleName = "Tarek";

            //   ObjectSpace.CommitChanges();


            //Customer cust = new Customer(workSession);


            //TestXafDemoContextInitializer db = new TestXafDemoContextInitializer();




            if (ObjectSpace.CanInstantiate(typeof(Customer)))
            {
                Customer customer = ObjectSpace.FindObject<Customer>(
                    CriteriaOperator.Parse("FirstName == ? && LastName == ?", "test", "test"));
                //if (customer == null)
                //{
                    customer = ObjectSpace.CreateObject<Customer>();
                    customer.FirstName = "test";
                    customer.LastName = "test";
                    customer.Company = "nnnnn Connection";
                    ObjectSpace.CommitChanges();

                //    }
            }



        }
        //private void simpleAction1_Executed(object sender, SimpleActionExecuteEventArgs e) {
        //}
        void simpleAction1_ExecuteCompleted(object sender, ActionBaseEventArgs e)
        {
         
                    View.ObjectSpace.Refresh();
               
        }

    }
}
