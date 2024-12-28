# Mutable Variables vs. Mutable References in F#

This example demonstrates a subtle but important difference between mutable variables and mutable references in F#.  While both allow modification, their behavior within functions can lead to unexpected results if not understood.

The `bug.fs` file contains code that highlights this difference. The `bugSolution.fs` file offers a clearer approach by consistently using mutable references.

This is a common error when transitioning from imperative to functional programming paradigms. Understanding these nuances is critical for writing correct and maintainable F# code.