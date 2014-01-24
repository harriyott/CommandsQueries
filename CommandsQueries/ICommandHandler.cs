﻿namespace CommandsQueries
{
    public interface ICommandHandler<in TCommand, out TResult> 
    {
        TResult Handle(TCommand command);
    }
}