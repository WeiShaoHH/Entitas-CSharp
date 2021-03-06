//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public AnyBaseListenerComponent anyBaseListener { get { return (AnyBaseListenerComponent)GetComponent(TestComponentsLookup.AnyBaseListener); } }
    public bool hasAnyBaseListener { get { return HasComponent(TestComponentsLookup.AnyBaseListener); } }

    public void AddAnyBaseListener(System.Collections.Generic.List<IAnyBaseListener> newValue) {
        var index = TestComponentsLookup.AnyBaseListener;
        var component = (AnyBaseListenerComponent)CreateComponent(index, typeof(AnyBaseListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyBaseListener(System.Collections.Generic.List<IAnyBaseListener> newValue) {
        var index = TestComponentsLookup.AnyBaseListener;
        var component = (AnyBaseListenerComponent)CreateComponent(index, typeof(AnyBaseListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyBaseListener() {
        RemoveComponent(TestComponentsLookup.AnyBaseListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherAnyBaseListener;

    public static Entitas.IMatcher<TestEntity> AnyBaseListener {
        get {
            if (_matcherAnyBaseListener == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.AnyBaseListener);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherAnyBaseListener = matcher;
            }

            return _matcherAnyBaseListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public void AddAnyBaseListener(IAnyBaseListener value) {
        var listeners = hasAnyBaseListener
            ? anyBaseListener.value
            : new System.Collections.Generic.List<IAnyBaseListener>();
        listeners.Add(value);
        ReplaceAnyBaseListener(listeners);
    }

    public void RemoveAnyBaseListener(IAnyBaseListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyBaseListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyBaseListener();
        } else {
            ReplaceAnyBaseListener(listeners);
        }
    }
}
