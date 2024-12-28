let mutable y = ref 10

let g () =
    y := !y + 1
    printf "%d\n" !y

g();; // Output: 11
g();; // Output: 12

//Alternative using a function to encapsulate the mutation and return a new value, promoting immutability:

let h (y : int ref) : int =
  let newValue = !y + 1
  y := newValue
  newValue

let mutable z = ref 10
printf "%d\n" (h z) // Output 11
printf "%d\n" (h z) // Output 12
