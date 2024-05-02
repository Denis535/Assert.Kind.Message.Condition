# Overview
The assertion library with a very convenient fluent interface.

## Assertions example
- ```Assert.Argument.Message( $"ArgumentException" ).Valid( ... )```
- ```Assert.Argument.Message( $"ArgumentOutOfRangeException" ).InRange( ... )```
- ```Assert.Argument.Message( $"ArgumentNullException" ).NotNull( ... )```
- ```Assert.Operation.Message( $"InvalidOperationException" ).Valid( ... )```
- ```Assert.Object.Message( $"ObjectNotInitializedException" ).Initialized( ... )```
- ```Assert.Object.Message( $"ObjectDisposedException" ).Alive( ... )```

## Exceptions example
- ```throw Exceptions.Internal.Exception( $"Exception" )```
- ```throw Exceptions.Internal.NullReference( $"NullReferenceException" )```
- ```throw Exceptions.Internal.NotSupported( $"NotSupportedException" )```
- ```throw Exceptions.Internal.NotImplemented( $"NotImplementedException" )```
