namespace DesignPatternsGangOfFour.Behavioral.State
{
    public class TCPConnection
    {
        private TCPState state;

        public TCPConnection()
        {
            this.state = TCPClosed.Instance();
        }
        
        public void ActiveOpen()
        {
            this.state.ActiveOpen(this);
        }

        public void PassiveOpen()
        {
            this.state.PassiveOpen(this);
        }

        public void Close()
        {
            this.state.Close(this);
        }

        public void Send()
        {
            this.state.Send(this);
        }

        public void Acknowledge()
        {
            this.state.Acknowledge(this);
        }

        public void Synchronize()
        {
            this.state.Synchronize(this);
        }

        public void ProcessOctet(TCPOctetStream octetStream)
        {
            this.state.Transmit(this, octetStream);
        }

        public void ChangeState(TCPState state)
        {
            this.state = state;
        }
    }
}