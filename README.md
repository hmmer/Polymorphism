#### Understanding Polymorphism

### Polymorphism
```
Polymorphism is the ability of an object to taken on many forms.
```

### Static Polymorphism
```
Despite having the same method name, the parameters must differ in type, or count, or order. 
```

### Dynamic Polymorphism
```
identical method name and signature parameters.

Reference variable will determine which methods to be called based on the object.

Ex: 
Laptop lenovo = new Lenovo();
Laptop azuz = new Azuz();

Laptop is super class
reference varilable is lenovo
Lenovo() is object

In the 1st ex, "lenovo" reference vaiable will decide object (Lenovo()) methods to be called.
```

## Other Information

•	Static Polymorphism wont work if the return type is different and name and parameters are same.

•	"base" can be used inside constructors of child class to access base class properties and methods.
