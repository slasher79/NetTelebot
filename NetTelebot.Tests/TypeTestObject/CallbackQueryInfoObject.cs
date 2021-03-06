﻿using NetTelebot.Type;
using Newtonsoft.Json.Linq;

namespace NetTelebot.Tests.TypeTestObject
{
    internal static class CallbackQueryInfoObject
    {
        /// <summary>
        /// This object represents an incoming callback query from a callback button in an inline keyboard. 
        /// If the button that originated the query was attached to a message sent by the bot, the field message will be present. 
        /// If the button was attached to a message sent via the bot (in inline mode), the field inline_message_id will be present. 
        /// Exactly one of the fields data or game_short_name will be present.
        /// See <see href="https://core.telegram.org/bots/api#callbackquery">API</see>
        /// </summary>
        /// <param name="id">Unique identifier for this query</param>
        /// <param name="userInfo">Sender</param>
        /// <param name="messageInfo">Optional. 
        /// Message with the callback button that originated the query. 
        /// Note that message content and message date will not be available if the message is too old</param>
        /// <param name="inlineMessageId">Optional. 
        /// Identifier of the message sent via the bot in inline mode, that originated the query.</param>
        /// <param name="chatInstance">Global identifier, uniquely corresponding to the chat to which the message with the callback button was sent. 
        /// Useful for high scores in games.</param>
        /// <param name="data">Optional. Data associated with the callback button. 
        /// Be aware that a bad client can send arbitrary data in this field.</param>
        /// <param name="gameShortName">Optional. Short name of a Game to be returned, 
        /// serves as the unique identifier for the game</param>
        /// <returns><see cref="CallbackQueryInfo"/></returns>
        internal static JObject GetObject(string id, JObject userInfo, JObject messageInfo,
            string inlineMessageId, string chatInstance, string data, string gameShortName)
        {
            dynamic callbackQuery = new JObject();

            callbackQuery.id = id;
            callbackQuery.from = userInfo;
            callbackQuery.message = messageInfo;
            callbackQuery.inline_message_id = inlineMessageId;
            callbackQuery.chat_instance = chatInstance;
            callbackQuery.data = data;
            callbackQuery.game_short_name = gameShortName;

            return callbackQuery;
        }
    }
}
