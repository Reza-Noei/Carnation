namespace Domain
{
    public class Transaction
    {
        /// <summary>
        /// Server which has requested this transaction
        /// </summary>
        public Server Server { get; set; }
        
        /// <summary>
        /// Commit Time in Mili Second 
        /// </summary>
        public long CommitTime { get; set; }
    }
}