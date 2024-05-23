namespace System;
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

public class Tests {

    [Test]
    public void Test_00_Exceptions() {
        // Exceptions.Argument
        NUnit.Framework.Assert.Catch<ArgumentException>( () => throw Exceptions.Argument.ArgumentException( $"ArgumentException" ) );
        NUnit.Framework.Assert.Catch<ArgumentOutOfRangeException>( () => throw Exceptions.Argument.ArgumentOutOfRangeException( $"ArgumentOutOfRangeException" ) );
        NUnit.Framework.Assert.Catch<ArgumentNullException>( () => throw Exceptions.Argument.ArgumentNullException( $"ArgumentNullException" ) );
        // Exceptions.Operation
        NUnit.Framework.Assert.Catch<InvalidOperationException>( () => throw Exceptions.Operation.InvalidOperationException( $"InvalidOperationException" ) );
        // Exceptions.Object
        NUnit.Framework.Assert.Catch<ObjectNotReadyException>( () => throw Exceptions.Object.ObjectNotReadyException( $"ObjectNotReadyException" ) );
        NUnit.Framework.Assert.Catch<ObjectDisposedException>( () => throw Exceptions.Object.ObjectDisposedException( $"ObjectDisposedException" ) );
        // Exceptions.Internal
        NUnit.Framework.Assert.Catch<Exception>( () => throw Exceptions.Internal.Exception( $"Exception" ) );
        NUnit.Framework.Assert.Catch<NullReferenceException>( () => throw Exceptions.Internal.NullReference( $"NullReferenceException" ) );
        NUnit.Framework.Assert.Catch<NotSupportedException>( () => throw Exceptions.Internal.NotSupported( $"NotSupportedException" ) );
        NUnit.Framework.Assert.Catch<NotImplementedException>( () => throw Exceptions.Internal.NotImplemented( $"NotImplementedException" ) );
    }

    [Test]
    public void Test_01_Assertions() {
        // Assert.Argument
        NUnit.Framework.Assert.Catch<ArgumentException>( () => Assert.Argument.Message( $"ArgumentException" ).Valid( false ) );
        NUnit.Framework.Assert.Catch<ArgumentOutOfRangeException>( () => Assert.Argument.Message( $"ArgumentOutOfRangeException" ).InRange( false ) );
        NUnit.Framework.Assert.Catch<ArgumentNullException>( () => Assert.Argument.Message( $"ArgumentNullException" ).NotNull( false ) );
        // Assert.Operation
        NUnit.Framework.Assert.Catch<InvalidOperationException>( () => Assert.Operation.Message( $"InvalidOperationException" ).Valid( false ) );
        // Assert.Object
        NUnit.Framework.Assert.Catch<ObjectNotReadyException>( () => Assert.Object.Message( $"ObjectNotReadyException" ).Ready( false ) );
        NUnit.Framework.Assert.Catch<ObjectDisposedException>( () => Assert.Object.Message( $"ObjectDisposedException" ).NotDisposed( false ) );
    }

    [Test]
    public void Test_02_GetMessageString() {
        TestContext.WriteLine( Exceptions.GetMessageStringDelegate( $"Value: {null}" ) );
        TestContext.WriteLine( Exceptions.GetMessageStringDelegate( $"Value: {777}" ) );
        TestContext.WriteLine( Exceptions.GetMessageStringDelegate( $"Values: ({new int[] { 666, 777 }})" ) );
        TestContext.WriteLine( Exceptions.GetMessageStringDelegate( $"Values: ({new object?[] { null, 666, 777 }})" ) );
    }

}
