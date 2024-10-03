using Assignment1EnterpriseSoftware.Models;
using System.Collections.Generic;

namespace Assignment1EnterpriseSoftware.Data
{
    public class RequestRepository
    {
        private static List<Request> requests = new List<Request>();
        private static int requestId = 1;

        public void AddRequest(Request request)
        {
            request.Id = requestId++;
            requests.Add(request);
        }

        public List<Request> GetAllRequests()
        {
            return requests;
        }
    }
}
