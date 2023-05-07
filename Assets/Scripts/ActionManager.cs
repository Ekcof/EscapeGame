using System;
using System.Collections.Generic;
using System.Linq;

public class ActionHolder
{
    public Action Action;
    public Type ObjectType;
    public string Name;
}

public static class ActionManager
{
    private static List<ActionHolder> actions = new List<ActionHolder>();

    public static void AddAction(Action action, Type type, string name = "")
    {
        ActionHolder actHolder = new ActionHolder() { Action = action, ObjectType = type, Name = name };
        actions.Add(actHolder);
    }

    public static void RemoveAllActionsByName(string name)
    {
        for (int i = 0; i < actions.Count; i++)
        {
            if (actions[i].Name == name)
                actions.RemoveAt(i);
        }
    }

    public static void RemoveAllActionsByType(Type type)
    {
        for (int i = 0; i < actions.Count; i++)
        {
            if (actions[i].ObjectType == type)
                actions.RemoveAt(i);
        }
    }

    public static void ExecuteActionByName(string actionName)
    {
        foreach (var action in actions)
        {
            if (actionName == action.Name)
            {
                action.Action.Invoke();
            }
        }
    }
}