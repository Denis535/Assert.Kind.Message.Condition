namespace System;
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

public class Tests {

    [Test]
    public void Test_00_Exceptions() {
        NUnit.Framework.Assert.Catch<ArgumentException>( () => throw Exceptions.Argument.ArgumentException( $"ArgumentException" ) );
        NUnit.Framework.Assert.Catch<ArgumentOutOfRangeException>( () => throw Exceptions.Argument.ArgumentOutOfRangeException( $"ArgumentOutOfRangeException" ) );
        NUnit.Framework.Assert.Catch<ArgumentNullException>( () => throw Exceptions.Argument.ArgumentNullException( $"ArgumentNullException" ) );

        NUnit.Framework.Assert.Catch<InvalidOperationException>( () => throw Exceptions.Operation.InvalidOperationException( $"InvalidOperationException" ) );

        NUnit.Framework.Assert.Catch<ObjectNotInitializedException>( () => throw Exceptions.Object.ObjectNotInitializedException( $"ObjectNotInitializedException" ) );
        NUnit.Framework.Assert.Catch<ObjectDisposedException>( () => throw Exceptions.Object.ObjectDisposedException( $"ObjectDisposedException" ) );

        NUnit.Framework.Assert.Catch<Exception>( () => throw Exceptions.Internal.Exception( $"Exception" ) );
        NUnit.Framework.Assert.Catch<NullReferenceException>( () => throw Exceptions.Internal.NullReference( $"NullReferenceException" ) );
        NUnit.Framework.Assert.Catch<NotSupportedException>( () => throw Exceptions.Internal.NotSupported( $"NotSupportedException" ) );
        NUnit.Framework.Assert.Catch<NotImplementedException>( () => throw Exceptions.Internal.NotImplemented( $"NotImplementedException" ) );
    }

    [Test]
    public void Test_01_Assertions() {
        NUnit.Framework.Assert.Catch<ArgumentException>( () => Assert.Argument.Message( $"ArgumentException" ).Valid( false ) );
        NUnit.Framework.Assert.Catch<ArgumentOutOfRangeException>( () => Assert.Argument.Message( $"ArgumentOutOfRangeException" ).InRange( false ) );
        NUnit.Framework.Assert.Catch<ArgumentNullException>( () => Assert.Argument.Message( $"ArgumentNullException" ).NotNull( false ) );
        NUnit.Framework.Assert.Catch<InvalidOperationException>( () => Assert.Operation.Message( $"InvalidOperationException" ).Valid( false ) );
        NUnit.Framework.Assert.Catch<ObjectNotInitializedException>( () => Assert.Object.Message( $"ObjectNotInitializedException" ).Initialized( false ) );
        NUnit.Framework.Assert.Catch<ObjectDisposedException>( () => Assert.Object.Message( $"ObjectDisposedException" ).Alive( false ) );
    }

    [Test]
    public void Test_02_GetMessageString() {
        TestContext.WriteLine( Exceptions.GetMessageStringDelegate( $"Value: {null}" ) );
        TestContext.WriteLine( Exceptions.GetMessageStringDelegate( $"Value: {777}" ) );
        TestContext.WriteLine( Exceptions.GetMessageStringDelegate( $"Values: ({new int[] { 666, 777 }})" ) );
        TestContext.WriteLine( Exceptions.GetMessageStringDelegate( $"Values: ({new object?[] { null, 666, 777 }})" ) );
    }

}
