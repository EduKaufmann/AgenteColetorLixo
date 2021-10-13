using System;

namespace AgenteColetorLixo
{
    internal class Agent
    {
        private String _type;
        private int _charge;
        private Tuple<int, int> _local;
        private String _dentinyAgent;

        public Agent(String type, Tuple<int, int> local, String destinyAgent)
        {
            _type = type;
            _local = local;
            _dentinyAgent = destinyAgent;
        }

        public string Type
        {
            get => _type;
        }

        public int Charge
        {
            get => _charge;
            set => _charge = value;
        }

        public Tuple<int, int> Local
        {
            get => _local;
            set => _local = value;
        }

        public string DestinyAgent
        {
            get => _dentinyAgent;
            set => _dentinyAgent = value;
        }

        public static void MoveAgent(String[,] matrix, Agent currentAgent)
        {
            Random rnd = new Random();
            int step = -1;
            int column = currentAgent.Local.Item1;
            int row = currentAgent.Local.Item2;
            while (step != 1)
            {
                int move = rnd.Next(1, 5);
                switch (move)
                {
                    case 1:
                        step = Up(matrix, currentAgent, column, row);
                        if (step == 0)
                        {
                            column = column - 1;
                            currentAgent.Local = currentAgent.Local;
                        }
                        break;
                    case 2:
                        step = Left(matrix, currentAgent, column, row);
                        if (step == 0)
                        {
                            row = row - 1;
                        }
                        break;
                    case 3:
                        step = Right(matrix, currentAgent, column, row);
                        if (step == 0)
                        {
                            row = row + 1;
                        }
                        break;
                    case 4:
                        step = Down(matrix, currentAgent, column, row);
                        if (step == 0)
                        {
                            column = column + 1;
                        }
                        break;
                    default:
                        step = -1;
                        break;
                }
            }
            Console.WriteLine(currentAgent.Type + " chegou em " + currentAgent.DestinyAgent);
            Console.WriteLine("Na Coluna: " + currentAgent.Local.Item1 + " Linha: " + currentAgent.Local.Item2);
        }

        private static int Up(String[,] matrix, Agent currentAgent, int column, int row)
        {
            String destiny = currentAgent.DestinyAgent;
            Boolean pass;
            String valueMatrix = string.Empty;
            if ((column - 1) >= matrix.GetLength(0)
                || row >= matrix.GetLength(1)
                || column - 1 < 0)// out of bounds
            {
                pass = false;
            }
            else
            {
                valueMatrix = matrix[(column - 1), row];
                if (string.IsNullOrEmpty(valueMatrix))
                {
                    pass = false;
                }
                else if (valueMatrix == ("0").ToString())
                {
                    pass = true;
                }
                else if (valueMatrix == (destiny).ToString())
                {
                    pass = true;
                }
                else
                {
                    pass = false;
                }
            }

            if (pass)
            {
                String value = matrix[column, row];
                matrix[column, row] = "0";
                if (valueMatrix != (destiny).ToString())
                {
                    matrix[(column - 1), row] = value;
                    Console.WriteLine(value + " subiu");
                    return 0;
                }
                else
                {
                    matrix[(column - 1), row] = destiny + "/" + value;
                    currentAgent.Local = Tuple.Create((column - 1), row); //Current Point in Object
                    Console.WriteLine(value + " subiu");
                    return 1;
                }
            }
            else
            {
                return -1;
            }
        }

        private static int Down(String[,] matrix, Agent currentAgent, int column, int row)
        {
            String destiny = currentAgent.DestinyAgent;
            Boolean pass;
            String valueMatrix = string.Empty;
            if ((column + 1) >= matrix.GetLength(0)
                || row >= matrix.GetLength(1))// out of bounds
            {
                pass = false;
            }
            else
            {
                valueMatrix = matrix[(column + 1), row];
                if (string.IsNullOrEmpty(valueMatrix))
                {
                    pass = false;
                }
                else if (valueMatrix == ("0").ToString())
                {
                    pass = true;
                }
                else if (valueMatrix == (destiny).ToString())
                {
                    pass = true;
                }
                else
                {
                    pass = false;
                }
            }

            if (pass)
            {
                String value = matrix[column, row];
                matrix[column, row] = "0";
                if (valueMatrix != (destiny).ToString())
                {
                    matrix[(column + 1), row] = value;
                    Console.WriteLine(value + " desceu");
                    return 0;
                }
                else
                {
                    matrix[(column + 1), row] = destiny + "/" + value;
                    currentAgent.Local = Tuple.Create((column + 1), row); //Current Point in Object
                    Console.WriteLine(value + " desceu");
                    return 1;
                }
            }
            else
            {
                return -1;
            }
        }

        private static int Left(String[,] matrix, Agent currentAgent, int column, int row)
        {
            String destiny = currentAgent.DestinyAgent;
            Boolean pass;
            String valueMatrix = string.Empty;
            if (column >= matrix.GetLength(0)
                || (row - 1) >= matrix.GetLength(1)
                || row - 1 < 0)// out of bounds
            {
                pass = false;
            }
            else
            {
                valueMatrix = matrix[column, (row - 1)];
                if (string.IsNullOrEmpty(valueMatrix))
                {
                    pass = false;
                }
                else if (valueMatrix == ("0").ToString())
                {
                    pass = true;
                }
                else if (valueMatrix == (destiny).ToString())
                {
                    pass = true;
                }
                else
                {
                    pass = false;
                }
            }

            if (pass)
            {
                String value = matrix[column, row];
                matrix[column, row] = "0";
                if (valueMatrix != (destiny).ToString())
                {
                    matrix[column, (row - 1)] = value;
                    Console.WriteLine(value + " andou para esquerda");
                    return 0;
                }
                else
                {
                    matrix[column, (row - 1)] = destiny + "/" + value;
                    currentAgent.Local = Tuple.Create(column, (row - 1)); //Current Point in Object
                    Console.WriteLine(value + " andou para esquerda");
                    return 1;
                }
            }
            else
            {
                return -1;
            }
        }

        private static int Right(String[,] matrix, Agent currentAgent, int column, int row)
        {
            String destiny = currentAgent.DestinyAgent;
            Boolean pass;
            String valueMatrix = string.Empty;
            if (column >= matrix.GetLength(0)
                || (row + 1) >= matrix.GetLength(1))// out of bounds
            {
                pass = false;
            }
            else
            {
                valueMatrix = matrix[column, (row + 1)];
                if (string.IsNullOrEmpty(valueMatrix))
                {
                    pass = false;
                }
                else if (valueMatrix == ("0").ToString())
                {
                    pass = true;
                }
                else if (valueMatrix == (destiny).ToString())
                {
                    pass = true;
                }
                else
                {
                    pass = false;
                }
            }

            if (pass)
            {
                String value = matrix[column, row];
                matrix[column, row] = "0";
                if (valueMatrix != (destiny).ToString())
                {
                    matrix[column, (row + 1)] = value;
                    Console.WriteLine(value + " andou para direita");
                    return 0;
                }
                else
                {
                    matrix[column, (row + 1)] = destiny + "/" + value;
                    currentAgent.Local = Tuple.Create(column, (row + 1)); //Current Point in Object
                    Console.WriteLine(value + " andou para direita");
                    return 1;
                }
            }
            else
            {
                return -1;
            }
        }

        public static int RemoveGarbage(Agent currentAgent, Garbage currentGarbage, String[,] matrix)
        {
            if (currentAgent.Charge < 5)
            {
                if (currentAgent.Charge + currentGarbage.Garbages > 5)
                {
                    int diff = 5 - currentAgent.Charge;
                    if (diff > currentGarbage.Garbages)
                    {
                        currentAgent.Charge = currentAgent.Charge + currentGarbage.Garbages;
                        currentGarbage.Garbages -= currentGarbage.Garbages;

                        //Clear the garbage because is empty
                        String valMatrix = matrix[currentGarbage.Local.Item1, currentGarbage.Local.Item2];
                        valMatrix = valMatrix.Replace(currentGarbage.Type, ("L" + currentGarbage.Type));
                        matrix[currentGarbage.Local.Item1, currentGarbage.Local.Item2] = valMatrix;
                        ExitGarbage(matrix, currentAgent, currentGarbage);

                        return 0;
                    }
                    else
                    {//Agent is full but garbage not
                        currentAgent.Charge = currentAgent.Charge + diff;
                        currentGarbage.Garbages = currentGarbage.Garbages - diff;
                        ExitGarbage(matrix, currentAgent, currentGarbage);

                        return 1;
                    }
                }
                else
                {
                    currentAgent.Charge = currentAgent.Charge + currentGarbage.Garbages;
                    currentGarbage.Garbages -= currentGarbage.Garbages;

                    //Clear the garbage because is empty
                    String valMatrix = matrix[currentGarbage.Local.Item1, currentGarbage.Local.Item2];
                    valMatrix = valMatrix.Replace(currentGarbage.Type, ("L" + currentGarbage.Type));
                    matrix[currentGarbage.Local.Item1, currentGarbage.Local.Item2] = valMatrix;
                    ExitGarbage(matrix, currentAgent, currentGarbage);

                    if (currentAgent.Charge == 5)
                    {
                        return 1;
                    }
                    return 0;
                }
            }
            return -1;
        }

        private static void ExitGarbage(String[,] matrix, Agent currentAgent, Garbage currentGarbage)
        {
            String value = matrix[currentAgent.Local.Item1, currentAgent.Local.Item2];
            value = value.Replace(("/" + currentAgent.Type), "");
            matrix[currentAgent.Local.Item1, currentAgent.Local.Item2] = value;

            matrix[(currentAgent.Local.Item1 - 1), currentAgent.Local.Item2] = currentAgent.Type;
            currentAgent.Local = Tuple.Create((currentAgent.Local.Item1 - 1), currentAgent.Local.Item2); //Current Point in Object
            Console.WriteLine(currentAgent.Type + " saiu de " + currentGarbage.Type);
        }
    }
}
