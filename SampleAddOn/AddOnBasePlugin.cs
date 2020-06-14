using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CXS.Retail.Extensibility;
using System.Windows.Forms;

namespace SampleAddOnForMCEvents
{
    /// <summary>
    /// Add on details like name ,company ,description,version etc.
    /// </summary>
    class AddOnBasePlugin:BasePlugin
    {           
        public override string CompanyName
        {
          get { return "SoftConsult Ltd"; }
        }   
        
        public override string Description
        {
            get { return "Block request number if it does not  match the numbering series";}
        }

        /// <summary>
        /// Start up method for add on. Here, we can define custom menus for MC or POS.
        /// </summary>
        public override void Start()
        {
            base.Start();         
        }

        public override void ShutDown()
        {
            base.ShutDown();
        }

        //Specify addon version.
        public override Version VersionInfo
        {
            get
            {
                return new Version("1.0.0.0");
            }            
        }

        public override string Name
        {
            get { return "AddonForRequestNumber"; }
        }
    }
}
