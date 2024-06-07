# Overview
The assertions library with a very convenient fluent interface.

## Assertions Example
```
// Assert.Argument
Assert.Argument.Message( $"ArgumentException" ).Valid( ... )
Assert.Argument.Message( $"ArgumentNullException" ).NotNull( ... )
Assert.Argument.Message( $"ArgumentOutOfRangeException" ).InRange( ... )

// Assert.Operation
Assert.Operation.Message( $"InvalidOperationException" ).Valid( ... )
Assert.Operation.Message( $"ObjectNotReadyException" ).Ready( ... )
Assert.Operation.Message( $"ObjectDisposedException" ).NotDisposed( ... )
```

## Exceptions Example
```
// Exceptions.Argument
throw Exceptions.Argument.ArgumentException( $"ArgumentException" )
throw Exceptions.Argument.ArgumentNullException( $"ArgumentNullException" )
throw Exceptions.Argument.ArgumentOutOfRangeException( $"ArgumentOutOfRangeException" )

// Exceptions.Operation
throw Exceptions.Operation.InvalidOperationException( $"InvalidOperationException" )
throw Exceptions.Operation.ObjectNotReadyException( $"ObjectNotReadyException" )
throw Exceptions.Operation.ObjectDisposedException( $"ObjectDisposedException" )

// Exceptions.Internal
throw Exceptions.Internal.Exception( $"Exception" )
throw Exceptions.Internal.NullReference( $"NullReferenceException" )
throw Exceptions.Internal.NotSupported( $"NotSupportedException" )
throw Exceptions.Internal.NotImplemented( $"NotImplementedException" )
```
