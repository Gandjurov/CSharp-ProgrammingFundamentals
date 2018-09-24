using System;
using System.Collections.Generic;
using System.Linq;

namespace RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            var eventIdToNames = new Dictionary<int, string>();
            var eventParticipants = new Dictionary<int, List<string>>();

            while (true)
            {

                var input = Console.ReadLine(); //input data
                if (input == "Time for Code")
                {
                    break;
                }

                //Split input data per elements
                var commandParts = input.Split(
                    new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //event ID
                var eventId = 0;
                if (!int.TryParse(commandParts[0], out eventId))
                {
                    continue;
                }

                //event name set
                var eventName = commandParts[1];
                if (!eventName.StartsWith("#"))
                {
                    continue;
                }
                eventName = eventName.Trim('#');

                // participants set
                var invalidParticipants = false;
                var participants = new List<string>(); // check participant names?

                for (int i = 2; i < commandParts.Length; i++)
                {
                    var participant = commandParts[i];
                    if (!participant.StartsWith("@"))
                    {
                        invalidParticipants = true;
                        break;
                    }

                    participants.Add(participant);
                }

                if (invalidParticipants)
                {
                    continue;
                }

                if (eventIdToNames.ContainsKey(eventId))
                {
                    var existingEventName = eventIdToNames[eventId];
                    if (existingEventName == eventName)
                    {
                        eventParticipants[eventId].AddRange(participants);
                    }
                    
                }
                else
                {
                    eventIdToNames[eventId] = eventName;
                    eventParticipants[eventId] = new List<string>(participants);
                }
            }

            var events = eventParticipants
                .Select(kvp => new
                {
                    Id = kvp.Key,
                    Name = eventIdToNames[kvp.Key],
                    Participants = kvp.Value
                    .Distinct()
                    .OrderBy(p => p)
                    .ToList()

                })
                .OrderByDescending(kvp => kvp.Participants.Count)
                .ThenBy(ev => ev.Name)
                .ToList(); // check order by name?

            foreach (var ev in events)
            {
                var evId = ev.Id;
                var evName = ev.Name;
                var participants = ev.Participants; // check distinct participants

                Console.WriteLine($"{evName} - {participants.Count}");


                foreach (var participant in participants)
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
