namespace DataGenerators
module NumberGenerator =
    let rnd = System.Random()
    let RandomArray length = [for i in 1..length do rnd.Next(1, 100)]
    let SortedArray length = [for i in 1..length -> i] 