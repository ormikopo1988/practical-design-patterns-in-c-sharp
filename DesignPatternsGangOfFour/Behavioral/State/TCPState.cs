namespace DesignPatternsGangOfFour.Behavioral.State
{
    public abstract class TCPState
    {
        public virtual void Transmit(TCPConnection connection, TCPOctetStream octetStream)
        {
            // Some default behavior
        }

        public virtual void ActiveOpen(TCPConnection connection)
        {
            // Some default behavior
        }

        public virtual void PassiveOpen(TCPConnection connection)
        {
            // Some default behavior
        }

        public virtual void Close(TCPConnection connection)
        {
            // Some default behavior
        }

        public virtual void Synchronize(TCPConnection connection)
        {
            // Some default behavior
        }

        public virtual void Acknowledge(TCPConnection connection)
        {
            // Some default behavior
        }

        public virtual void Send(TCPConnection connection)
        {
            // Some default behavior
        }

        protected void ChangeState(TCPConnection connection, TCPState state)
        {
            connection.ChangeState(state);
        }
    }
}