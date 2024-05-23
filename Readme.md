# Overview
The assertions library with a very convenient fluent interface.

## Assertions Example
```
// Assert.Argument
Assert.Argument.Message( $"ArgumentException" ).Valid( ... )
Assert.Argument.Message( $"ArgumentOutOfRangeException" ).InRange( ... )
Assert.Argument.Message( $"ArgumentNullException" ).NotNull( ... )

// Assert.Operation
Assert.Operation.Message( $"InvalidOperationException" ).Valid( ... )

// Assert.Object
Assert.Object.Message( $"ObjectNotReadyException" ).Ready( ... )
Assert.Object.Message( $"ObjectDisposedException" ).NotDisposed( ... )
```

## Exceptions Example
```
// Exceptions.Argument
throw Exceptions.Argument.ArgumentException( $"ArgumentException" )
throw Exceptions.Argument.ArgumentOutOfRangeException( $"ArgumentOutOfRangeException" )
throw Exceptions.Argument.ArgumentNullException( $"ArgumentNullException" )

// Exceptions.Operation
throw Exceptions.Operation.InvalidOperationException( $"InvalidOperationException" )

// Exceptions.Object
throw Exceptions.Object.ObjectNotReadyException( $"ObjectNotReadyException" )
throw Exceptions.Object.ObjectDisposedException( $"ObjectDisposedException" )

// Exceptions.Internal
throw Exceptions.Internal.Exception( $"Exception" )
throw Exceptions.Internal.NullReference( $"NullReferenceException" )
throw Exceptions.Internal.NotSupported( $"NotSupportedException" )
throw Exceptions.Internal.NotImplemented( $"NotImplementedException" )
```
