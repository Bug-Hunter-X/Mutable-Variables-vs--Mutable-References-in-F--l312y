let mutable x = 10

let f () =
    x <- x + 1
    printf "%d\n" x

f();; // Output: 11
f();; // Output: 12

let mutable y = ref 10

let g () =
    y := !y + 1
    printf "%d\n" !y

g();; // Output: 11
g();; // Output: 12