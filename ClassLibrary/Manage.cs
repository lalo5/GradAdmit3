using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The top-layer class that interfaces with the ui to allow the user to interact with the system
    /// </summary>
    public class Manage
    {
        public User currentUser { get; set; }
        private List<User> AllUsers;
        private List<GradApplication> Applications;
        private GradApplication AppToAssign;
        private Queue<GradApplication> BufferQueue;  //Holds a giant list of all of the applications and their complexities
        public AppReviews appReviews { get; set; }  // add this back in when AppReviews is complete
        public Courses SelectedCourses { get; set; }// add this back in when Courses is complete
        public Criteria criteria { get; set; }      // add this back in when Criteria is complete
        private const int Number = 106;
        public Course SelectedCourse;

        /// <summary>
        /// Default constructor, should populate from the database
        /// </summary>
        public Manage()
        {
            AllUsers = new List<User>();
        }

        public int GetNumber()
        {
            return Number;
        }

        public Manage(List<GradApplication> GradAppsIn, List<User> UsersIn, User UserIn)
        {
            Applications = new List<GradApplication>(GradAppsIn);
            AllUsers = new List<User>(UsersIn);
            currentUser = new User(UserIn);
        }

        /// <summary>
        /// Method for filling the queues with applications to review from the buffer queue
        /// </summary>
        public void AutoFill()
        {
            bool blnFull = false;
            bool blnEmpty = false;
            bool blnReadyForBalancing = false;
            int minIndex = 0;
            List<User> AvailableUsers = new List<User>(AllUsers);
            while(!blnEmpty && !blnFull)    //continue until each queue is at the cutoff or there are no more applications in the buffer
            {
                if(!blnReadyForBalancing)   //if we are on the first pass, don't worry about deciding where to place something
                {
                    for (int iCount = 0; iCount < AvailableUsers.Count; iCount++) //For each user queue
                    {
                        if(BufferQueue.Count > 0)                                //Make sure that there is something in the buffer
                        {
                            if(AvailableUsers[iCount].AppsToReview.Enqueue(BufferQueue.Peek()) < 0)  //Attempt to enqueue the buffer
                            {   
                                AvailableUsers.RemoveAt(iCount);                    //If the queue is at the limit, remove it from the list
                                iCount--;
                            }
                            else
                            {
                                BufferQueue.Dequeue();                              //Otherwise, actually pop the object off of the queue because it was actually assigned
                            }
                        }
                        else
                        {
                            blnEmpty = true;
                            break;
                        }
                    }
                }

                minIndex = FindMin(AllUsers);

                if (BufferQueue.Count > 0)                                //Make sure that there is something in the buffer
                {
                    if (AvailableUsers[minIndex].AppsToReview.Enqueue(BufferQueue.Peek()) < 0)  //Attempt to enqueue the buffer
                    {
                        AvailableUsers.RemoveAt(minIndex);                    //If the queue is at the limit, remove it from the list
                    }
                    else
                    {
                        BufferQueue.Dequeue();                              //Otherwise, actually pop the object off of the queue because it was actually assigned
                    }
                }
                else
                {
                    blnEmpty = true;
                    break;
                }

                if (AvailableUsers.Count == 0)
                {
                    blnFull = true;
                }
                if(this.BufferQueue.Count == 0)
                {
                    blnEmpty = true;
                }
            }

        }

        /// <summary>
        /// Method for recommending a reviewer for the next application in the queue
        /// </summary>
        /// <returns></returns>
        public User RecommendNext()
        {
            User temp;
            List<User> AvailableUsers = new List<User>();
            int minIndex = 0;
            for (int iCount = 0; iCount < AllUsers.Count; iCount++)
            {
                if(!AllUsers[iCount].AppsToReview.IsAtCutoff())
                {
                    AvailableUsers.Add(AllUsers[iCount]);
                }
            }
            if(AvailableUsers.Count > 1)
            {
                minIndex = FindMin(AllUsers);
                temp = new User(AllUsers[minIndex]);
            }
            else
            {
                temp = new User(AllUsers[0]);
            }
            return temp;
        }//end RecommendNext()

        public int FindMin(List<User> UsersIn)
        {
            double dMin = 999999999;
            double temp = 0.0;
            int iIndex = 0;
            for(int iCount = 0; iCount < UsersIn.Count; iCount++)
            {
                temp = UsersIn[iCount].AppsToReview.GetTotal();

                if(temp < dMin)
                {
                    dMin = temp;
                    iIndex = iCount;
                }
            }

            return iIndex;
        }//end FindMin(List<User>)

        public int LogIn(User UserIn)
        {
            int iStatus = 0;
            UserIn.status = UserStatus.active;  //Altering the passed user to coencide with a specific use
            UserIn.type = UserType.Aide;        //Will replace with an IComparable interface later for better searching
            //int iPos = AllUsers.BinarySearch(UserIn);
            int iPos = -1;
            for(int iCount = 0; iCount < AllUsers.Count; iCount++)
            {
                if(UserIn.email == AllUsers[iCount].email && UserIn.password == AllUsers[iCount].password)
                {
                    iPos = iCount;
                }
            }

            if (iPos >= 0)
            {
                currentUser = AllUsers[iPos];
            }
            else
            {
                iStatus = -1;   //Indicate that no such user was found
            }
            return iStatus;
        }//end LogIn(User)

        public int CreateAccount(User UserIn)
        {
            int iStatus = 0;
            if(UserIn != null)
            {
                if(UserIn.email != null && UserIn.password != null)
                {
                    UserIn.status = UserStatus.active;
                    UserIn.type = UserType.Aide;    //Aide by default, will replace with a better system later
                    AllUsers.Add(UserIn);
                    iStatus = 1;    //Success
                }
                else
                {
                    iStatus = -1;   //return if a user is not filled out properly
                }
            }
            else
            {
                iStatus = -2;       //return if a user is null
            }

            return iStatus;
        }//end CreateAccount(User)

        public int CreateCourse(AbstractCourse CourseIn)
        {
            int iStatus = 0;    //0 indicates nothing happened
            Course NewCourse;

            if(!(CourseIn is Courses))  //Make sure you're not passing a course list here
            {
                NewCourse = new Course((Course)CourseIn);
                                                            //Save the new course to the database?
            }
            else
            {
                iStatus = -1;           //Indicates a course was passed
            }

            return iStatus;
        }//end CreateCourse(AbstractCourse)

        public int CollectionToQueue()
        {
            int iStatus = -1;

            return iStatus;
        }//end CollectionToQueue()

        public int GenerateBufferDictionary()
        {
            int iStatus = -1;

            return iStatus;
        }//end GenerateBufferDictionary()

        public int GenerateWeight(AppReview ReviewIn)
        {
            int iWeight = -1;

            return iWeight;
        }//end GenerateWeight()

        public int PlaceApplication()
        {
            int iStatus = -1;

            return iStatus;
        }

        /// <summary>
        /// Search the database based on the passed name
        /// </summary>
        /// <param name="NameIn"></param>
        /// <returns></returns>
        public int LoadCourse(String NameIn)
        {
            int iStatus = 0;

            return iStatus;
        }//end LoadCourse(String)

         /// <summary>
        /// returns a string of user specific data
        /// </summary>
        public override string ToString()
        {
            return string.Format(
                "Program currently being managed by" +"\n"+
                "User ID:".PadRight(20) + "{0}\n"+
                "User Type:".PadRight(20) + "{1}\n",
                currentUser.id,
                currentUser.type);
        }
    }//end Manage
}
