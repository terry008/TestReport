using System;
using System.Collections;
using System.Collections.Generic;

namespace SKL.Report.Core.UI.Models
{
    //报告视图模型
    public class ReportViewModel
    {
        public string Title { get; set; }
        public string StuName { get; set; }
        //总得分
        public decimal TotalScores { get; set; }
        //是否显示排名
        public bool ShowSort { get; set; }
        //我的排名
        public int MySort { get; set; }
        //超越人数百分比
        public int OverRate { get; set; }
        //是否显示单科排名
        public bool ShowSubjectSort { get; set; }

        //所有科目汇总
        public List<ReportSubjectSummary> SubjectSummary { get; set; }

        //是否显示考试说明
        public bool ShowTestRemark { get; set; }
        //考试说明
        public string TestRemark { get; set; }
        //是否显示整体分析
        public bool ShowAnalysis { get; set; }
        //整体分析标题
        public string AnalysisTitle { get; set; }
        //整体分析
        public string Analysis { get; set; }
        //是否显示获奖名单
        public bool ShowAwards { get; set; }
        //获奖标题
        public string AwardsTitle { get; set; }
        //获奖名单
        public string Awards { get; set; }
        //科目详情
        public List<SubjectDetail> Subjects { get; set; }

        //考试总评
        public string TotalRemark { get; set; }
    }

    //科目详情
    public class SubjectDetail
    {
        public string SubjectName { get; set; }
        public decimal MySubjectScores { get; set; }
        public decimal SubjectTotalScores { get; set; }
        public string SubjectPy { get; set; }
        public List<ModulesDetail> Modules { get; set; }
    }

    //模块详情
    public class ModulesDetail
    {
        public string ModuleName { get; set; }
        public decimal ModuleTotalScores { get; set; }
        public decimal ModuleAvgScores { get; set; }
        public decimal MyModuleScores { get; set; }
        public int MyModuleSort { get; set; }

        public List<TimuDetail> Timus { get; set; }

        public string ModulesPy { get; set; }
    }

    //题目详情
    public class TimuDetail
    {
        public string TMNo { get; set; }
        public decimal Scores { get; set; }
        public decimal Avgs { get; set; }
        public decimal MyScores { get; set; }
        public string TmPy { get; set; }
    }

    //科目汇总
    public class ReportSubjectSummary
    {
        public string SubjectName { get; set; }
        public decimal TotalScores { get; set; }
        public decimal AvgScores { get; set; }
        public decimal MyScores { get; set; }
        public int MySort { get; set; }
    }
}
