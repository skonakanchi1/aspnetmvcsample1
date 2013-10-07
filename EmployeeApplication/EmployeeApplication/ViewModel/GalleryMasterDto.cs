using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApplication.ViewModel
{
   public class GalleryMasterDto
    {
        private int _iD;
        public virtual int ID
        {
            get
            {
                return this._iD;
            }
            set
            {
                this._iD = value;
            }
        }

        private string _name;
        public virtual string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        private string _displayName;
        public virtual string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
    }
}
