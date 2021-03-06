﻿using unirest;
using unirestt;
using System.Net.Http;
using Xunit;

namespace unirest_netcore_tests.http
{
  public class HttpClientHelperTests
  {
    [Fact]
    public static void HttpClientHelper_Should_Reqeust()
    {
      HttpClientHelper.Request<string>(new HttpRequest(HttpMethod.Get, "http://www.google.com"));
    }

    [Fact]
    public static void HttpClientHelper_Should_Reqeust_Async()
    {
      HttpClientHelper.RequestAsync<string>(new HttpRequest(HttpMethod.Get, "http://www.google.com"));
    }

    [Fact]
    public static void HttpClientHelper_Should_Reqeust_With_Fields()
    {
      HttpClientHelper.Request<string>(
        new HttpRequest(HttpMethod.Post, "http://www.google.com").field("test", "value"));
    }

    [Fact]
    public static void HttpClientHelper_Should_Reqeust_Async_With_Fields()
    {
      HttpClientHelper.RequestAsync<string>(
        new HttpRequest(HttpMethod.Post, "http://www.google.com").field("test", "value"));
    }
  }
}