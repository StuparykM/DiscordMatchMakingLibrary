using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordMatchMaking
{
    public class UserName
    {
        #region Data Members
        private string _userName;
        private bool _primary;
        #endregion

        #region Properties

        public string UserNames
        {
            get
            {
                return _userName;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(_userName))
                {
                    throw new ArgumentNullException("Must provide a username");
                }
            }
        }

        public bool Primary
        {
            get
            {
                return _primary;
            }
            internal set
            {
                _primary = value;
            }
        }


        #endregion

        #region Methods
        #endregion

        #region Construtor
        public UserName(string userName, bool isPrimary = false)
        {
            UserNames = userName;
            Primary = isPrimary;
        }
        #endregion
    }
}
