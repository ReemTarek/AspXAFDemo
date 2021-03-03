using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestXafDemo.Module.BusinessObjects.Marketing
{
    [NavigationItem("Marketing")]

    public class Testimonial : BaseObject
    {
        public Testimonial(Session session) : base(session) { createdOn = DateTime.Now; }
      
       
        string quote;
        [FieldSize(FieldSizeAttribute.Unlimited)]

        public string Quote
        {
            get { return quote; }
            set { SetPropertyValue(nameof(Quote),ref quote, value); }
        }
        string highlight;
        [FieldSize(512)]
        public string Highlight
        {
            get { return highlight; }
            set { SetPropertyValue(nameof(Highlight),ref highlight, value); }
        }
        DateTime createdOn;
        [VisibleInListView(false)]
        public DateTime CreatedOn
        {
            get { return createdOn; }
            internal set { SetPropertyValue(nameof(CreatedOn),ref createdOn, value); }
        }
        string tags;
        public string Tags
        {
            get { return tags; }
            set { SetPropertyValue(nameof(Tags),ref tags, value); }
        }
        Customer customer;
        [Association]
        public Customer Customer
        {
            get { return customer; }
            set { SetPropertyValue(nameof(Customer), ref customer, value); }
        }




    }
}
