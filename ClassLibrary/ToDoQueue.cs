using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    /// <summary>
    /// Every user of the system has a todoqueue that contains the applications for them to complete.
    /// </summary>
    public class ToDoQueue
    {
        private Queue<GradApplication> ToDo;
        private int cutoff;
        private double QueueTotal;

        #region Constructors
        public ToDoQueue()
        {
            ToDo = new Queue<GradApplication>();
            cutoff = 1;
        }//end ToDoQueue()

        public ToDoQueue(int cutoffIn)
        {
            this.ToDo = new Queue<GradApplication>();
            this.cutoff = cutoffIn;
        }

        public ToDoQueue(Queue<GradApplication> QueueIn, int cutoffIn)
        {
            this.ToDo = new Queue<GradApplication>(QueueIn);
            this.cutoff = cutoffIn;
            CalculateTotal();   //Update the total
        }//end ToDoQueue(Queue<GradApplication>, QueueIn, int)

        public ToDoQueue(ToDoQueue QueueIn)
        {
            this.ToDo = new Queue<GradApplication>(QueueIn.ToDo);
            this.cutoff = QueueIn.cutoff;
            this.QueueTotal = QueueIn.QueueTotal;
        }//end ToDoQueue(QueueIn)
        #endregion

        #region Getters
        public Queue<GradApplication> GetQueue()
        {
            return this.ToDo;
        }//end GetQueue()

        public int GetCutoff()
        {
            return this.cutoff;
        }//end GetCutoff()

        public double GetTotal()
        {
            return this.QueueTotal;
        }//end GetTotal()

        #endregion

        #region Utility Methods
        public int Enqueue(GradApplication AppIn)
        {
            int iReturnCode = 0;
            if((ToDo.Count + 1) != cutoff)
            {
                ToDo.Enqueue(AppIn);
                CalculateTotal();   //Update the total
            }
            else
            {
                iReturnCode = -1;
            }
            return iReturnCode;
        }//end EnqueueApplication(GradApplication)

        public GradApplication Dequeue()
        {
            GradApplication Temp = ToDo.Dequeue();
            CalculateTotal();   //Update the total
            return Temp;
        }//end DequeueApplication()

        /// <summary>
        /// Used for error checking, should not need to update the total, returns the top of the queue without dequeing it
        /// </summary>
        /// <returns> The value at the top of the queue </returns>
        public GradApplication Peek()
        {
            return ToDo.Peek();
        }//end Peek()
        #endregion

        /// <summary>
        /// Adds up all of the values in the queue to get the queue's total workload
        /// </summary>
        public void CalculateTotal()
        {
            double dComplexity = 0;
            if(this.ToDo.Peek() != null && this.ToDo.Count > 0)    //if there's actually stuff in the queue
            {
                GradApplication[] temp = new GradApplication[ToDo.Count];
                ToDo.CopyTo(temp, 0);
                for(int iCount = 0; iCount < ToDo.Count; iCount++)
                {
                    dComplexity += temp[iCount].GetComplexityRating();
                }
            }
        }//end CalculateTotal()

        public bool IsAtCutoff()
        {
            return (this.ToDo.Count == this.cutoff);
        }//end IsAtCutoff()

    }//end ToDoQueue
}
