﻿using PublicApiGeneratorTests.Examples;
using System;
using Xunit;

namespace PublicApiGeneratorTests
{
    public class Event_visibility :  ApiGeneratorTestsBase
    {
        [Fact]
        public void Should_output_public_event()
        {
            AssertPublicApi<ClassWithPublicEvent>(
@"namespace PublicApiGeneratorTests.Examples
{
    public class ClassWithPublicEvent
    {
        public ClassWithPublicEvent() { }
        public event System.EventHandler Event;
    }
}");
        }

        [Fact]
        public void Should_output_protected_event()
        {
            AssertPublicApi<ClassWithProtectedEvent>(
@"namespace PublicApiGeneratorTests.Examples
{
    public class ClassWithProtectedEvent
    {
        public ClassWithProtectedEvent() { }
        protected event System.EventHandler Event;
    }
}");
        }

        [Fact]
        public void Should_output_protected_internal_event()
        {
            AssertPublicApi<ClassWithProtectedInternalEvent>(
                @"namespace PublicApiGeneratorTests.Examples
{
    public class ClassWithProtectedInternalEvent
    {
        public ClassWithProtectedInternalEvent() { }
        protected event System.EventHandler Event;
    }
}");
        }

        [Fact]
        public void Should_not_output_private_protected_event()
        {
            AssertPublicApi<ClassWithPrivateProtectedEvent>(
                @"namespace PublicApiGeneratorTests.Examples
{
    public class ClassWithPrivateProtectedEvent
    {
        public ClassWithPrivateProtectedEvent() { }
    }
}");
        }

        [Fact]
        public void Should_not_output_private_event()
        {
            AssertPublicApi<ClassWithPrivateEvent>(
@"namespace PublicApiGeneratorTests.Examples
{
    public class ClassWithPrivateEvent
    {
        public ClassWithPrivateEvent() { }
    }
}");
        }

        [Fact]
        public void Should_not_output_internal_event()
        {
            AssertPublicApi<ClassWithInternalEvent>(
@"namespace PublicApiGeneratorTests.Examples
{
    public class ClassWithInternalEvent
    {
        public ClassWithInternalEvent() { }
    }
}");
        }
    }

    // ReSharper disable ClassNeverInstantiated.Global
    // ReSharper disable UnusedMember.Global
    // ReSharper disable UnusedMember.Local
    // ReSharper disable UnusedAutoEventAccessor.Local
    namespace Examples
    {
        public class ClassWithPublicEvent
        {
            public event EventHandler Event;
        }

        public class ClassWithProtectedEvent
        {
            protected event EventHandler Event;
        }

        public class ClassWithPrivateEvent
        {
            private event EventHandler Event;
        }

        public class ClassWithInternalEvent
        {
            internal event EventHandler Event;
        }

        public class ClassWithProtectedInternalEvent
        {
            protected internal event EventHandler Event;
        }

        public class ClassWithPrivateProtectedEvent
        {
            private protected event EventHandler Event;
        }
    }
    // ReSharper restore UnusedMember.Local
    // ReSharper restore UnusedMember.Global
    // ReSharper restore ClassNeverInstantiated.Global
}
