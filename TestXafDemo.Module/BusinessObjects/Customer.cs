using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestXafDemo.Module.BusinessObjects.Marketing
{
    [NavigationItem("Marketing")]
   public class Customer : BaseObject
    {   public Customer(Session session): base(session)
        {

        }
   
        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { SetPropertyValue(nameof(FirstName), ref firstName, value); }
        }
        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { SetPropertyValue(nameof(LastName), ref lastName, value); }
        }
        string email;
        public string Email
        {
            get { return email; }
            set { SetPropertyValue(nameof(Email), ref email, value); }
        }
        string company;
        public string Company
        {
            get { return company; }
            set { SetPropertyValue(nameof(Company), ref company, value); }
        }
        string occupation;
        public string Occupation
        {
            get { return occupation; }
            set { SetPropertyValue(nameof(Occupation), ref occupation, value); }
        }
        [Association, DevExpress.ExpressApp.DC.Aggregated]
        public XPCollection<Testimonial> Testimonials
        {
            get { return GetCollection<Testimonial>(nameof(Testimonials)); }
        }
        [NotMapped]
        public string FullName
        {
            get
            {
                string namePart = string.Format("{0} {1}", FirstName, LastName);
                return Company != null ? string.Format("{0} ({1})", namePart, Company) : namePart;
            }
        }
        byte[] photo;
        [ImageEditor(ListViewImageEditorCustomHeight = 75, DetailViewImageEditorFixedHeight = 150)]
        public byte[] Photo
        {
            get { return photo; }
            set { SetPropertyValue(nameof(Photo),ref photo, value); }
        }

    
     

      
    }
}
