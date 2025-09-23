using BenchmarkDotNet.Running;
using CommonTypesProject.Classes;
using CommonTypesProject.Delegates;
using CommonTypesProject.Delegates.AdditionalPracticeClasses;
using CommonTypesProject.Delegates.EventDelegate;
using CommonTypesProject.Enumerations;
using CommonTypesProject.Structures;

//BenchmarkRunner.Run<BenchmarkSealedClass>();

//StructTest.Compare();

//EnumsExample.AccessToEnum();

//DelegatesType.Execute();
//DelegatePredicateType.ExecutePredicate();

//// Event delegate:
var video = new Video() { Title = "Video 1"};
var videoEncoder = new DelegateEventType();
var mailService = new MailService();
var messageService = new MessageService();

videoEncoder.VideoEncoded += mailService.OnVideoEncodedSubscriber;
videoEncoder.VideoEncoded += messageService.OnVideoEncodedSubscriber;

videoEncoder.Encode(video);