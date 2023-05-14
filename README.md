# SimpleFactoryDesignPatternWithCSharp

# Simple Factory Design Pattern With CSharp, From PassionateCoders Youtube Channel
    https://www.youtube.com/watch?v=DyZqyTlKDgI&list=PLsV97AQt78NTrqUAZM562JbR3ljX19JFR&index=5

# UseCase
    in some cases where some classes share a common interface,
    and we want to create an object of one of these classes,
    but we don't know which one at runtime.
    
    so instead of creating the object with if condition that will not be flexible to business requirements,
    we can use the simple factory design pattern to create the object for us.

    It is a simple class with one method that holds the logic of creating the object and return the object.
############################################################################################################

# Null Object Design Pattern
    https://www.youtube.com/watch?v=iASju68gtwA&list=PLsV97AQt78NTrqUAZM562JbR3ljX19JFR&index=6

# UseCase
    in the above case where we have used switch case in the factory method,
    in the default case we can return null object instead of null,
    so we can avoid null reference exception.

# Implementation
    we create a concrete class that implements the interface (NullPaymentObject),
    