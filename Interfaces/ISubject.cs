﻿namespace ObserverPattern.Interfaces;

//Define the Subject
public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}