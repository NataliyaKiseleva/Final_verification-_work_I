string[] Array = { "HELLO", "<->", "World", ":)" };
string newArray = string.Join(", ", Array);
Console.Write($"[{newArray}] -> ");

for (int i = 0; i < Array.Length; i++){
    if (Array[i].Length <= 3){
        if (i != Array.Length - 1){
            Console.Write("[");
            Console.Write($"{Array[i]}, ");
        }
        else{
            Console.Write($"{Array[i]}");
            Console.Write("]");
        }
    }
}

