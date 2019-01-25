namespace DesignPatternsGangOfFour.Behavioral.State
{
    public class TCPListen : TCPState
    {
        private static TCPState state;

        public static TCPState Instance()
        {
            if (state == null)
            {
                state = new TCPListen();
            }

            return state;
        }

        public override void Send(TCPConnection connection)
        {
            // send SYN, receiv e SYN, ACK , etc.

            this.ChangeState(connection, TCPEstablished.Instance());
        }
    }
}