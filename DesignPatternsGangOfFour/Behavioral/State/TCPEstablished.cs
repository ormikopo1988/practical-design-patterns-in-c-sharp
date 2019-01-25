namespace DesignPatternsGangOfFour.Behavioral.State
{
    public class TCPEstablished : TCPState
    {
        private static TCPState state;

        public static TCPState Instance()
        {
            if(state == null)
            {
                state = new TCPEstablished();
            }

            return state;
        }

        public override void Close(TCPConnection connection)
        {
            // send PIN, receive ACK of FIN

            this.ChangeState(connection, TCPListen.Instance());
        }

        public override void Transmit(TCPConnection connection, TCPOctetStream octetStream)
        {
            connection.ProcessOctet(octetStream);
        }
    }
}