using System;

namespace AgenteColetorLixo
{
    internal class Garbage
    {
        private String _type;
        private int _garbages;
        private Tuple<int, int> _local;

        public Garbage(String type, Tuple<int, int> local)
        {
            _type = type;
            _local = local;
            _garbages = 3;
        }

        public String Type
        {
            get => _type;
            set => _type = value;
        }

        public int Garbages
        {
            get => _garbages;
            set => _garbages = value;
        }

        public Tuple<int, int> Local
        {
            get => _local;
            set => _local = value;
        }
    }
}
