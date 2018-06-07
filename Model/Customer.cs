﻿using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Builder.FormFlow.Advanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StupidBotMessengerMultiDialogs.Model
{
    [Serializable]
    public class Customer
    {
        public enum UseSaveInfoResponse
        {
            Yes,
            Edit
        }
        public int ID { set; get; }
        //[Template(TemplateUsage.NotUnderstood, "Xin lỗi, định dạng ngày bị sai", "Quý khách vui lòng nhập đúng định dạng ngày")]
        [Prompt("Vui lòng nhập họ tên:")]
        public string Name { set; get; }
        //------------------------------------------------------Being modified Code by Huynh Kien Minh ( 1/5/2018 ) start at line 22
        [Template(TemplateUsage.NotUnderstood, "Số điện thoại không hợp lệ. Mời quý khách nhập lại")]
        [Pattern(@"(<Undefined control sequence>\d)?\s*\d{3}(-|\s*)\d{7}")]
        [Prompt("Vui lòng nhập số điện thoại:")]
        public string Phone { set; get; }
        [Optional]
        [Template(TemplateUsage.NotUnderstood, "Địa chỉ email không hợp lê. Mời quý khách nhập lại")]
        [Pattern(@"[a-z0-9!#$%&'*+\/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+\/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        [Prompt("Vui lòng nhập số email:")]
      
        public string Email { set; get; }
        [Optional]
        [Prompt("Vui lòng nhập địa chỉ:")]
        public string Address { get; set; }
    
        public DateTime DateOfBirth { get; set; }
     
        public string Nationality { get; set; }
        [Optional]
        [Template(TemplateUsage.NotUnderstood, "Số CMND phải 9 số. Mời quý khách nhập lại")]
        [Pattern(@"(<Undefined control sequence>\d)?\s*\d{3}(-|\s*)\d{6}")]
        [Prompt("Vui lòng nhập số CMND:")]
        //------------------------------------------------------Being modified Code by Huynh Kien Minh ( 1/5/2018 ) end at line 44
        public string PassportNumber { get; set; }

        public string FacebookID { get; set; }
        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }

        public bool Status { set; get; }

        public bool AskToUseSavedSenderInfo { get; set; }

        [Prompt]
        public UseSaveInfoResponse? UseSavedSenderInfo { get; set; }

        [Prompt]
        public bool SaveSenderInfo { get; set; }


        public static IForm<Customer> BuildCustomerForm()
        {
            return new FormBuilder<Customer>()
                .Field(nameof(Name))
                .Field(nameof(Phone))
                .Field(nameof(Email))
                .Field(nameof(Address))
                .Field(nameof(PassportNumber))
                .Build();
        }
    }
}