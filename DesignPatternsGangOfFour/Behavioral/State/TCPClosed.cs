namespace DesignPatternsGangOfFour.Behavioral.State
{
    public class TCPClosed : TCPState
    {
        private static TCPState state;

        public static TCPState Instance()
        {
            if (state == null)
            {
                state = new TCPClosed();
            }

            return state;
        }

        public override void ActiveOpen(TCPConnection connection)
        {
            // send SYN, receive SYN, ACK, etc.

            this.ChangeState(connection, TCPEstablished.Instance());
        }

        public override void PassiveOpen(TCPConnection connection)
        {
            this.ChangeState(connection, TCPListen.Instance());
        }
    }
}