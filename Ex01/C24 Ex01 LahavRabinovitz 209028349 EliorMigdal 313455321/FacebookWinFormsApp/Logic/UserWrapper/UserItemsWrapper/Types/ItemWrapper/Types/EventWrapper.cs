﻿using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.CustomeData;

namespace BasicFacebookFeatures.Logic.UserWrapper.UserItemsWrapper.Types.ItemWrapper.Types
{
    public class EventWrapper : IUserItemWrapper
    {
        public string Name { get; set; }
        public Event Event { get; set; }
        public EventData EventData { get; set; }
        public string Picture { get; set; }

        public EventWrapper(Event i_Event)
        {
            Name = i_Event.Name;
            Event = i_Event;
            Picture = i_Event.PictureNormalURL;
        }

        public EventWrapper(EventData i_CustomeData)
        {
            Name = i_CustomeData.Name;
            EventData = i_CustomeData;
            Picture = i_CustomeData.Picture;
        }
    }
}