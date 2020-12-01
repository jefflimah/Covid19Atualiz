namespace Covid19.Services
{
    internal class SymmetricSecurityKey
    {
        private byte[] key;

        public SymmetricSecurityKey(byte[] key)
        {
            this.key = key;
        }
    }
}