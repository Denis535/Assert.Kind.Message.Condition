namespace System {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    public static class Assertions {
        // Assertion
        public abstract class Assertion {
            public FormattableString? Message { get; }
            public Assertion(FormattableString? message) {
                Message = message;
            }
            public override string? ToString() {
                return Exceptions.GetMessageStringDelegate( Message );
            }
        }
        // Argument
        public class Argument : Assertion {
            public Argument(FormattableString? message) : base( message ) {
            }

            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void Valid([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.GetException<ArgumentException>( Message );
            }
            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void InRange([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.GetException<ArgumentOutOfRangeException>( Message );
            }
            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void NotNull([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.GetException<ArgumentNullException>( Message );
            }
        }
        // Operation
        public class Operation : Assertion {
            public Operation(FormattableString? message) : base( message ) {
            }

            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void Valid([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.GetException<InvalidOperationException>( Message );
            }
        }
        // Object
        public class Object : Assertion {
            public Object(FormattableString? message) : base( message ) {
            }

            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void Initialized([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.GetException<ObjectNotInitializedException>( Message );
            }
            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public void Alive([DoesNotReturnIf( false )] bool isValid) {
                if (!isValid) throw Exceptions.GetException<ObjectDisposedException>( Message );
            }
        }
    }
}
