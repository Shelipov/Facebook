using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facebook.Models
{
    public class FacebookOptions
    {
        //Возвращает или задает назначенный Facebook appId.
        public Guid id { get; set; }
        public string AppId { get; set; }

        //Возвращает или задает секрет приложения, назначенного Facebook.
        public string AppSecret { get; set; }

        //AuthenticationScheme в опциях соответствует логическому имени для определенной схемы аутентификации. 
        //Для использования одного и того же типа промежуточного программного обеспечения проверки подлинности в конвейере может быть присвоено другое значение.
        //public string AuthenticationScheme { get; set; }

        //Возвращает или задает URI, в котором клиент будет перенаправлен для проверки подлинности.
        //(Наследуется от OAuthOptions)
        public string AuthorizationEndpoint { get; set; }

        //Если true, то промежуточное по аутентификации должно обрабатывать автоматический вызов. 
        //Если false, промежуточное по проверки подлинности будет изменять ответы только при явном указании AuthenticationScheme.
        //public bool AutomaticChallenge { get; set; }

        //Если true, то промежуточное по аутентификации изменяет входящего пользователя запроса.
        //Если false, то по промежуточного слоя проверки подлинности будет предоставлять удостоверение только при явном указании AuthenticationScheme.
        //Наследуется от RemoteAuthenticationOptions
        public string BackchannelHttpHandler { get; set; }

        //Возвращает или задает значение тайм-аута в миллисекундах для обратной связи с удаленным поставщиком удостоверений.        
        public TimeSpan BackchannelTimeout { get; set; }

        //Путь запроса в базовом пути приложения, по которому будет возвращен агент пользователя. Middleware обработает этот запрос, когда он поступит.
        //Наследуется от RemoteAuthenticationOptions
        public string CallbackPath { get; set; }

        //Возвращает или задает издателя, который должен использоваться для любых созданных утверждений Наследуется от AuthenticationOptions
        public string ClaimsIssuer { get; set; }

        //Возвращает или задает идентификатор клиента, назначенный поставщиком.
        //Наследуется от OAuthOptions
        public string ClientId { get; set; }

        //Возвращает или задает назначенный поставщиком секрет клиента.
        //Наследуется от OAuthOptions
        public string ClientSecret { get; set; }

        //Дополнительные сведения о типе проверки подлинности, который предоставляется приложению.
        //Наследуется от AuthenticationOptions
        //public Microsoft.AspNetCore.Http.Authentication.AuthenticationDescription Description { get; set; }

        //Получение или установка текста, который пользователь может отображать в пользовательском интерфейсе входа.
        //Наследуется от RemoteAuthenticationOptions
        //public string DisplayName { get; set; }

        //Возвращает или задает IOAuthEvents, используемые для обработки событий проверки подлинности.
        //Наследуется от OAuthOptions
        public string Events { get; set; }

        //Список полей, извлекаемых из UserInformationEndpoint. https://developers.facebook.com/docs/graph-api/reference/user
        //public System.Collections.Generic.ICollection<string> Fields { get; set; }

        //Возвращает или задает ограничение по времени для завершения потока проверки подлинности (по умолчанию 15 минут).
        public TimeSpan RemoteAuthenticationTimeout { get; set; }

        //Определяет, должны ли маркеры доступа и обновления храниться в свойствах AuthenticationProperties 
        //после успешной авторизации. Это свойство имеет значение false по умолчанию, чтобы уменьшить размер итогового файла cookie проверки подлинности.
        //Наследуется от RemoteAuthenticationOptions
        //public System.Collections.Generic.ICollection<string> Scope { get; set; }

        //Возвращает или задает, если appsecret_proof должны быть созданы и отправлены с вызовами API Facebook. Это включено по умолчанию.
        public bool SendAppSecretProof { get; set; }

        //Возвращает или задает схему проверки подлинности, соответствующую промежуточному по,
        //ответственному за сохранение удостоверения пользователя после успешной проверки подлинности.
        //Это значение обычно соответствует промежуточному по cookie, зарегистрированному в классе Startup.
        //Когда опущен, SignInScheme используется как резервное значение.
        //Наследуется от RemoteAuthenticationOptions
        public string SignInScheme { get; set; }

        //Получает или задает Тип, используемый для защиты данных, обрабатываемых на middleware.
        //Наследуется от OAuthOptions
        //public Microsoft.AspNetCore.Authentication.ISecureDataFormat<Microsoft.AspNetCore.Http.Authentication.AuthenticationProperties> StateDataFormat { get; set; }

        //Только в целях тестирования.
        //Наследуется от OAuthOptions
        //[System.ComponentModel.EditorBrowsable]
        //public Microsoft.AspNetCore.Authentication.ISystemClock SystemClock { get; set; }

        //Получает или задает URI промежуточного будет доступ к Exchange oauth-токен.
        //Наследуется от OAuthOptions
        public string TokenEndpoint { get; set; }

        //Получает или задает URI промежуточного сможет получить информацию о пользователе. 
        //Это значение не используется в реализации по умолчанию, оно используется 
        //в пользовательских реализациях IOAuthAuthenticationEvents.Проверку подлинности или OAuthAuthenticationHandler.CreateTicketAsync.
        //Наследуется от OAuthOptions
        public string UserInformationEndpoint { get; set; }


    }
}
