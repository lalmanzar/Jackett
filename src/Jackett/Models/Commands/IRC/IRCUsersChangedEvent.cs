﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackett.Models.Commands.IRC
{
    public class IRCUsersChangedEvent : INotification
    {
        public string Id { get; set; }
    }
}