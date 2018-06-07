﻿using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Builder.FormFlow.Advanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StupidBotMessengerMultiDialogs.Model
{
    [Serializable]
    
    public class Reservation
    {
        public int ID { set; get; }
        [Template(TemplateUsage.NotUnderstood, "Xin lỗi, định dạng ngày bị sai.Mời quý khách nhập lại !!!", "Quý khách vui lòng nhập đúng định dạng ngày")]
        [Prompt("Vui lòng nhập vào thời gian nhận phòng (Ví dụ: 25/12/2018):")]
        public DateTime CheckInDateTime { get; set; }
        [Template(TemplateUsage.NotUnderstood, "Xin lỗi, định dạng ngày bị sai. Mời quý khách nhập lại !!", "Quý khách vui lòng nhập đúng định dạng ngày")]
        [Prompt("Vui lòng nhập vào thời gian trả phòng (Ví dụ: 25/12/2018):")]
        public DateTime CheckOutDateTime { get; set; }

        public string Note { get; set; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public int CustomerID { set; get; }

        public int RoomID { get; set; }

        public decimal Total { get; set; }

        public decimal? Deposit { get; set; }

        public bool IsPaid { get; set; }

        public static IForm<Reservation> BuildOrderForm()
        {
            return new FormBuilder<Reservation>()
                .Field(nameof(CheckInDateTime))
                   
                .Field(nameof(CheckOutDateTime))
                .Build();
        }
    }
}