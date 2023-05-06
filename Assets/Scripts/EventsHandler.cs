using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventsHandler
{
    private static List<Action> actions = new List<Action>();

    public static void AddAction(Action action)
    {
        actions.Add(action);
    }

    public static void RemoveAction(Action action)
    {
        actions.Remove(action);
    }

    public static void ExecuteAction(string actionName)
    {
        foreach (var action in actions)
        {
            var methodName = action.Method.Name;
            if (methodName == actionName)
            {
                action.Invoke();
            }
        }
    }
}