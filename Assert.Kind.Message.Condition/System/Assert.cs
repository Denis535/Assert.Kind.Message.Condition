namespace System {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    public static class Assert {
        public static class Argument {
            public static Assertion.Message<Assertion.Argument> Message(FormattableString? value) => new Assertion.Message<Assertion.Argument>( value );
        }
        public static class Operation {
            public static Assertion.Message<Assertion.Operation> Message(FormattableString? value) => new Assertion.Message<Assertion.Operation>( value );
        }
        public static class Object {
            public static Assertion.Message<Assertion.Object> Message(FormattableString? value) => new Assertion.Message<Assertion.Object>( value );
        }
    }
    // Assertion
    public static class Assertion {
        // Message
        public class Message<TKind> where TKind : Kind {
            internal FormattableString? Value { get; }
            public Message(FormattableString? value) {
                Value = value;
            }
            public override string? ToString() {
                return Exceptions.GetMessageStringDelegate( Value );
            }
        }
        // Kind
        public abstract class Kind {
            private protected Kind() {
            }
        }
        public abstract class Argument : Kind {
            private Argument() {
            }
        }
        public abstract class Operation : Kind {
            private Operation() {
            }
        }
        public abstract class Object : Kind {
            private Object() {
            }
        }

        // Argument
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void Valid(this Message<Argument> message, [DoesNotReturnIf( false )] bool isValid) {
            if (!isValid) throw Exceptions.GetException<ArgumentException>( message.Value );
        }
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void InRange(this Message<Argument> message, [DoesNotReturnIf( false )] bool isValid) {
            if (!isValid) throw Exceptions.GetException<ArgumentOutOfRangeException>( message.Value );
        }
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void NotNull(this Message<Argument> message, [DoesNotReturnIf( false )] bool isValid) {
            if (!isValid) throw Exceptions.GetException<ArgumentNullException>( message.Value );
        }

        // Operation
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void Valid(this Message<Operation> message, [DoesNotReturnIf( false )] bool isValid) {
            if (!isValid) throw Exceptions.GetException<InvalidOperationException>( message.Value );
        }

        // Object
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void Initialized(this Message<Object> message, [DoesNotReturnIf( false )] bool isValid) {
            if (!isValid) throw Exceptions.GetException<ObjectNotInitializedException>( message.Value );
        }
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void Alive(this Message<Object> message, [DoesNotReturnIf( false )] bool isValid) {
            if (!isValid) throw Exceptions.GetException<ObjectDisposedException>( message.Value );
        }

    }
}
