using HostelApp.Entities.Codes;

namespace HostelApp.Extensions
{
    public static class RoomTypeExtensions
    {
        public static string GetRoomTypeDescription(this RoomType roomType)
        {
            return roomType switch
            {
                RoomType.Стандарт => "Эконом",
                RoomType.Апартаменты => "Апартаменты",
                RoomType.Бизнес => "Бизнес-класс",
                RoomType.Люкс => "Люкс",
                RoomType.Все => "",
                _ => throw new MissingMemberException(nameof(roomType)),
            };
        }
    }
}
