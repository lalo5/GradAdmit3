using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{ 
    public enum UserStatus { active = 0, inactive = 1 };
    /// <summary>
    /// A member of the grad evaluation process, one of three types, see UserType
    /// </summary>
    public class User
    {
        public int id { get; }
        public string email { get; set; }
        public string password{ get; set; }
        public UserType type { get; set; }
        public UserStatus status { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public User()
        {
            
        }//end User()

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="idIn"></param>
        /// <param name="emailIn"></param>
        /// <param name="passwordIn"></param>
        /// <param name="TypeIn"></param>
        public User(int idIn, string emailIn, string passwordIn, UserType TypeIn)
        {
            this.id = idIn;
            this.email = emailIn;
            this.password = passwordIn;
            this.type = TypeIn;
        }//end User(int, string, string, UserType)

        public User(string emailIn, string passwordIn)
        {
            this.email = emailIn;
            this.password = passwordIn;
        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="UserIn"></param>
        public User(User UserIn)
        {
            this.id = UserIn.id;
            this.email = UserIn.email;
            this.password = UserIn.password;
            this.type = UserIn.type;
        }//end User(User)

        /// <summary>
        /// returns a string of user specific data
        /// </summary>
        public override string ToString()
        {
            return string.Format(
                "User ID:".PadRight(20) + "{0}\n"+
                "Email:".PadRight(20) + "{1}\n" +
                "User Type:".PadRight(20) + "{2}\n" +
                "User Status:".PadRight(20) + "{3}\n",
                id,
                email,
                type,
                status);
        }//end ToString()


    }
}
