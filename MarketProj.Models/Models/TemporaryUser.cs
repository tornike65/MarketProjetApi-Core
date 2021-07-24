using MarketProj.Models.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace MarketProj.Models.Models
{
    public class TemporaryUser : Entity
    {
        public TemporaryUser(string username, string role)
        {
            Username = username;
            Role = role;
        }

        public string Username { get; private set; }
        public string Role { get; private set; }
        public string UserIP { get; private set; }
        public string Token { get; private set; }

        public void SetIP(string ip)
        {
            //Regex ipReg = new Regex(@"[\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            //if (ipReg.IsMatch(ip))
            //{
            //    UserIP = ip;
            //}
            //else
            //{
            //    throw new Exception("invalid Ip");
            //}
            var isIp = IPAddress.TryParse(ip, out IPAddress iPAddress);
            if (isIp)
            {
                UserIP = ip;
            }
            else
            {
                throw new Exception("invalid Ip");
            }

        }

        public void SetToken(string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                Token = token;
            }
            else
            {
                throw new Exception("token is null");
            }
        }
    }
}
