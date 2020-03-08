namespace Arrays
{
    public class Dictionary
    {
        private string[] _key = new string[5];
        private string[,] _value = new string[5,5];

        public Dictionary()
        {
            _key[0] = "книга"; _value[0,0] = "book"; _value[0,1] = "книга";
            _key[1] = "ручка"; _value[1,0] = "pen"; _value[1,1] = "ручка";
            _key[2] = "солнце"; _value[2,0] = "sun"; _value[2,1] = "сонце";
            _key[3] = "яблоко"; _value[3,0] = "apple"; _value[3,1] = "яблуко";
            _key[4] = "стол"; _value[4, 0] = "table"; _value[4, 1] = "стола";
        }

        public string this[string index]
        {
            get
            {
                for (var i = 0; i < _key.Length; i++)
                {
                    if (_key[i] == index)
                    {
                        return $"{_key[i]} - {_value[i, 0]} - {_value[i, 1]}";
                    }
                    else if (_value[i, 0] == index)
                    {
                        return $"{_value[i, 0]} - {_key[i]} - {_value[i, 1]}";
                    }
                    else if (_value[i, 1] == index)
                    {
                        return $"{_value[i, 1]} - {_key[i]} - {_value[i, 0]}";
                    }
                }

                return $"{index}, нет перевода для этого слова.";
            }
        }
        
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _key.Length)
                    return $"{_key[index]} - {_value[index, 0]} - {_value[index, 1]}";
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}